using System;
using NLog;
using System.Data.SqlClient;

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
    }
}