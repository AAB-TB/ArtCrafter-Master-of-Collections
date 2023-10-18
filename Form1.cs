using System;
using NLog;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace ArtCrafter.MasterofCollections
{
    public partial class Form1 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        string connectionString = "Data Source=ALVIN-AB\\SQLEXPRESS;Initial Catalog=\"ArtCrafter: Master of Collections\";Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                List<CollectionItem> collectionItemDataList = await RetrieveDataFromDatabaseAsync();

                // Clear existing user controls in the FlowLayoutPanel.
                flowLayoutPanel1.Controls.Clear();

                foreach (CollectionItem data in collectionItemDataList)
                {
                    ItemUserControl recipeUserControl = new ItemUserControl(this, data);
                    recipeUserControl.SetImage(data.FrontImageFilePath);
                    recipeUserControl.SetTitle(data.Name);
                    flowLayoutPanel1.Controls.Add(recipeUserControl);
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in the LoadDataAsync method. Message: {0}", ex.Message);

                // Show a user-friendly error message
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async Task<List<CollectionItem>> RetrieveDataFromDatabaseAsync()
        {
            List<CollectionItem> collectionItemDataList = new List<CollectionItem>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Open the database connection
                    await connection.OpenAsync();

                    // SQL query to select image and title of recipes
                    string sqlQuery = "SELECT ci.ID, ci.Name, ci.FrontImageFilePath, ci.CategoryID " +
                                      "FROM CollectionItem ci";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int ID = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            string frontImageFilePath = reader.GetString(2);
                            int categoryID = reader.GetInt32(3);

                            // Create a collectionitem object and add it to the list
                            CollectionItem item = new CollectionItem
                            {
                                ID = ID,
                                Name = name,
                                FrontImageFilePath = frontImageFilePath,
                                CategoryID = categoryID
                            };
                            collectionItemDataList.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in the RetrieveDataFromDatabaseAsync method. Message: {0}", ex.Message);

            }

            return collectionItemDataList;
        }










        private void hemBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchtextbox_TextChanged(object sender, EventArgs e)
        {
            string searchText = searchtextbox.Text;

            try
            {
                // Implement autocomplete logic here
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    // Call a method to get and display autocomplete suggestions
                    DisplayAutocompleteSuggestions(searchText);
                }
                else
                {
                    LoadDataAsync();
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions here
                MessageBox.Show("An error occurred: " + ex.Message);
                logger.Error(ex, "An error occurred in searchTextBox_TextChanged. Message: {0}", ex.Message);
            }
        }

        private async void DisplayAutocompleteSuggestions(string searchText)
        {
            try
            {
                // Query the database for autocomplete suggestions
                List<string> suggestions = await GetAutocompleteSuggestionsAsync(searchText);

                // Clear the ListBox before adding new suggestions
                suggestionsListBox.Items.Clear();

                if (suggestions.Count > 0)
                {
                    // Add suggestions to the ListBox
                    suggestionsListBox.Items.AddRange(suggestions.ToArray());

                    // Show the ListBox below the search TextBox
                    suggestionsListBox.Location = new Point(searchtextbox.Location.X, searchtextbox.Location.Y + searchtextbox.Height);
                    suggestionsListBox.Visible = true;
                }
                else
                {
                    // If there are no suggestions, hide the ListBox
                    suggestionsListBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred while displaying autocomplete suggestions for search text: {0}. Message: {1}", searchText, ex.Message);

                // Show a user-friendly error message
                MessageBox.Show("An error occurred while displaying autocomplete suggestions: " + ex.Message);
            }
        }
        private async Task<List<string>> GetAutocompleteSuggestionsAsync(string searchText)
        {
            List<string> suggestions = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();


                    string sqlQuery = @"
                                    SELECT CI.Name, C.CategoryName
                                    FROM CollectionItem CI
                                    JOIN Category C ON CI.CategoryID = C.CategoryID
                                    WHERE (CI.Name LIKE @searchText + '%' OR C.CategoryName LIKE @searchText + '%');
                                    ";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", searchText);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                suggestions.Add(reader.GetString(0)); // Add item titles
                                suggestions.Add(reader.GetString(1)); // Add category names
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in GetAutocompleteSuggestionsAsync for search text: {0}. Message: {1}", searchText, ex.Message);

                // You can choose to re-throw the exception if needed
                throw;
            }

            return suggestions;
        }

        private void suggestionsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (suggestionsListBox.SelectedIndex != -1)
                {
                    string selectedSuggestion = suggestionsListBox.SelectedItem.ToString();
                    // Set the selected suggestion as the text in the searchTextBox
                    searchtextbox.Text = selectedSuggestion;
                    // Perform the search based on the selected suggestion
                    PerformSearch(selectedSuggestion);

                    // Explicitly hide the suggestionsListBox
                    suggestionsListBox.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in suggestionsListBox_SelectedIndexChanged_1. Message: {0}", ex.Message);

                // Show a user-friendly error message
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private async void PerformSearch(string selectedSuggestion)
        {
            try
            {
                List<CollectionItem> searchResults = await SearchItemsAsync(selectedSuggestion);
                suggestionsListBox.Visible = false;
                // Clear existing user controls in the FlowLayoutPanel.
                flowLayoutPanel1.Controls.Clear();

                foreach (CollectionItem data in searchResults)
                {
                    ItemUserControl itemUserControl = new ItemUserControl(this, data);
                    itemUserControl.SetImage(data.FrontImageFilePath);
                    itemUserControl.SetTitle(data.Name);
                    flowLayoutPanel1.Controls.Add(itemUserControl);
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in PerformSearch for selected suggestion: {0}. Message: {1}", selectedSuggestion, ex.Message);

                // Show a user-friendly error message
                MessageBox.Show("An error occurred during the search: " + ex.Message);
            }
        }

        private async Task<List<CollectionItem>> SearchItemsAsync(string searchText)
        {
            List<CollectionItem> searchResults = new List<CollectionItem>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    // SQL query to search for recipes based on title and category

                    string sqlQuery = @"
                                    SELECT CI.ID, CI.Name, CI.FrontImageFilePath
                                    FROM CollectionItem CI
                                    JOIN Category C ON CI.CategoryID = C.CategoryID
                                    WHERE (CI.Name LIKE @searchText + '%' OR C.CategoryName LIKE @searchText + '%');
                                    ";

                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                int ID = reader.GetInt32(0);
                                string name = reader.GetString(1);
                                string frontImageFilePath = reader.GetString(2);
                                //int categoryID = reader.GetInt32(3);

                                // Create a item object and add it to the search results
                                CollectionItem item = new CollectionItem
                                {
                                    ID = ID,
                                    Name = name,
                                    FrontImageFilePath = frontImageFilePath,
                                    //CategoryID = categoryID
                                };

                                searchResults.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log detailed error information using NLog
                logger.Error(ex, "An error occurred in SearchRecipesAsync for search text: {0}. Message: {1}", searchText, ex.Message);

                // You can choose to re-throw the exception if needed
                throw;
            }

            return searchResults;
        }


    }
}