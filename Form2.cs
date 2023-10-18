using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCrafter.MasterofCollections
{
    public partial class Form2 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        string connectionString = "Data Source=ALVIN-AB\\SQLEXPRESS;Initial Catalog=\"ArtCrafter: Master of Collections\";Integrated Security=True";
        private OpenFileDialog frontImageOpenFileDialog = new OpenFileDialog();
        private OpenFileDialog backImageOpenFileDialog = new OpenFileDialog();
        private int selectedItem;

        public Form2()
        {
            InitializeComponent();
            LoadCategories();
        }
        public Form2(int selectedItem)
        {
            InitializeComponent();
            LoadCategories();
            this.selectedItem = selectedItem;
            LoadItemDetails(selectedItem);
        }
        private void LoadItemDetails(int selectedItem)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string getItemQuery = "SELECT * FROM CollectionItem WHERE ID = @ItemID";

                    using (SqlCommand cmd = new SqlCommand(getItemQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemID", selectedItem);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            txtItemName.Text = reader["Name"].ToString();
                            purchaseDateDateTimePicker.Value = (DateTime)reader["PurchaseDate"];
                            purchasePriceTextBox.Text = reader["PurchasePrice"].ToString();
                            purchaseLocationTextBox.Text = reader["PurchaseLocation"].ToString();

                            if (reader["SaleDate"] != DBNull.Value)
                            {
                                saleDateCheckBox.Checked = true;
                                saleDateDateTimePicker.Value = (DateTime)reader["SaleDate"];
                            }

                            if (reader["SalePrice"] != DBNull.Value)
                            {
                                salePriceTextBox.Text = reader["SalePrice"].ToString();
                            }

                            if (reader["SaleLocation"] != DBNull.Value)
                            {
                                saleLocationTextBox.Text = reader["SaleLocation"].ToString();
                            }

                            descriptionTextBox.Text = reader["Description"].ToString();

                            // Set the selected category in the ComboBox
                            categoryComboBox.SelectedValue = reader["CategoryID"];

                            // Load front and back images from file paths
                            string frontImageFilePath = reader["FrontImageFilePath"].ToString();
                            string backImageFilePath = reader["BackImageFilePath"].ToString();

                            if (!string.IsNullOrEmpty(frontImageFilePath))
                            {
                                frontImagePictureBox.Image = Image.FromFile(frontImageFilePath);
                                frontImagePath = frontImageFilePath; // Set the image path variable.
                            }

                            if (!string.IsNullOrEmpty(backImageFilePath))
                            {
                                backImagePictureBox.Image = Image.FromFile(backImageFilePath);
                                backImagePath = backImageFilePath; // Set the image path variable.
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("LoadItemDetails", ex);
            }
        }

        private void hemBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                MessageBox.Show("Please enter an item name.");
                return false;
            }

            if (purchaseDateDateTimePicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please select a valid purchase date.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(purchasePriceTextBox.Text) || !decimal.TryParse(purchasePriceTextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid purchase price.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(purchaseLocationTextBox.Text))
            {
                MessageBox.Show("Please enter a purchase location.");
                return false;
            }

            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show("Please enter a description.");
                return false;
            }

            // Optional fields don't need validation.

            return true; // All mandatory fields are valid.
        }


        private async void addBtn_Click(object sender, EventArgs e)
        {
            using SqlConnection connection = new SqlConnection(connectionString);
            if (ValidateFields()) // Custom method to validate mandatory fields.
            {
                try
                {
                    using (connection)
                    {
                        await connection.OpenAsync();

                        // Prepare the SQL command with parameters to prevent SQL injection.
                        string sql = @"INSERT INTO CollectionItem (Name, PurchaseDate, PurchasePrice, PurchaseLocation, SaleDate, SalePrice, SaleLocation, FrontImageFilePath, BackImageFilePath, Description, CategoryID) 
                               VALUES (@Name, @PurchaseDate, @PurchasePrice, @PurchaseLocation, @SaleDate, @SalePrice, @SaleLocation, @FrontImageFilePath, @BackImageFilePath, @Description, @CategoryID);";

                        using SqlCommand command = new SqlCommand(sql, connection);

                        // Set parameter values from your controls.
                        command.Parameters.AddWithValue("@Name", txtItemName.Text);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDateDateTimePicker.Value);
                        command.Parameters.AddWithValue("@PurchasePrice", decimal.Parse(purchasePriceTextBox.Text));
                        command.Parameters.AddWithValue("@PurchaseLocation", purchaseLocationTextBox.Text);
                        command.Parameters.AddWithValue("@SaleDate", saleDateCheckBox.Checked ? (object)saleDateDateTimePicker.Value : DBNull.Value);
                        command.Parameters.AddWithValue("@SalePrice", string.IsNullOrEmpty(salePriceTextBox.Text) ? (object)DBNull.Value : decimal.Parse(salePriceTextBox.Text));
                        command.Parameters.AddWithValue("@SaleLocation", string.IsNullOrEmpty(saleLocationTextBox.Text) ? (object)DBNull.Value : saleLocationTextBox.Text);
                        // command.Parameters.AddWithValue("@FrontImageFilePath", frontImagePictureBox.ImageLocation);
                        // command.Parameters.AddWithValue("@BackImageFilePath", backImagePictureBox.ImageLocation);
                        command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                        command.Parameters.AddWithValue("@CategoryID", categoryComboBox.SelectedValue); // Assuming your ComboBox is data-bound.
                        command.Parameters.AddWithValue("@FrontImageFilePath", frontImagePath);
                        command.Parameters.AddWithValue("@BackImageFilePath", backImagePath);

                        await command.ExecuteNonQueryAsync();
                    }
                    MessageBox.Show("Item added successfully!");
                    ClearForm(); // Custom method to clear fields.
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all mandatory fields.");
            }
        }

        private void ClearForm()
        {
            // Clear the text in textboxes
            txtItemName.Text = string.Empty;
            purchasePriceTextBox.Text = string.Empty;
            purchaseLocationTextBox.Text = string.Empty;
            salePriceTextBox.Text = string.Empty;
            saleLocationTextBox.Text = string.Empty;
            frontImagePictureBox.Text = string.Empty;
            frontImagePictureBox.Tag = null;
            backImagePictureBox.Text = null;
            backImagePictureBox.Tag = null;
            descriptionTextBox.Text = string.Empty;
            nycategorytxtbox.Text = string.Empty;

            // Reset date pickers
            purchaseDateDateTimePicker.Value = DateTime.Now;
            saleDateDateTimePicker.Value = DateTime.Now;

            // Clear selected value in combo boxes
            categoryComboBox.SelectedIndex = -1;

            // Clear the sale date checkbox
            saleDateCheckBox.Checked = false;
        }


        private void nycategoriSave_Click(object sender, EventArgs e)
        {
            string categoryName = nycategorytxtbox.Text; // Get the category name from the TextBox

            if (!string.IsNullOrEmpty(categoryName))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string insertCategoryQuery = "INSERT INTO Category (CategoryName) VALUES (@CategoryName); SELECT SCOPE_IDENTITY()";

                        using (SqlCommand cmd = new SqlCommand(insertCategoryQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@CategoryName", categoryName);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Category Saved Successfully!");
                                nycategorytxtbox.Text = ""; // Clear the TextBox
                                LoadCategories();
                            }
                            else
                            {
                                MessageBox.Show("Failed to save the category.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    logger.Error(ex, "Error saving a category.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.");
            }
        }


        private void LoadCategories()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string getCategoryQuery = "SELECT CategoryID, CategoryName FROM Category";
                    using (SqlCommand cmd = new SqlCommand(getCategoryQuery, connection))
                    {
                        DataTable categoryDataTable = new DataTable();
                        categoryDataTable.Load(cmd.ExecuteReader());

                        categoryComboBox.DataSource = categoryDataTable;
                        categoryComboBox.DisplayMember = "CategoryName";
                        categoryComboBox.ValueMember = "CategoryID";
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error("LoadCategories", ex);
            }
        }

        string frontImagePath; // Add this variable to store the front image path.
        string backImagePath;  // Add this variable to store the back image path.
        private void frontImagePictureBox_Click_1(object sender, EventArgs e)
        {
            try
            {
                frontImageOpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico";
                if (frontImageOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    frontImagePath = frontImageOpenFileDialog.FileName;
                    frontImagePictureBox.Image = Image.FromFile(frontImagePath);
                }
            }
            catch (Exception ex)
            {
                logger.Error("frontImagePictureBox_Click", ex);
            }
        }

        private void backImagePictureBox_Click_1(object sender, EventArgs e)
        {
            try
            {
                backImageOpenFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.ico";
                if (backImageOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    backImagePath = backImageOpenFileDialog.FileName;
                    backImagePictureBox.Image = Image.FromFile(backImagePath);
                }
            }
            catch (Exception ex)
            {
                logger.Error("backImagePictureBox_Click", ex);
            }
        }


        private async void updateBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (ValidateFields()) // Custom method to validate mandatory fields.
                {
                    try
                    {
                        using (connection)
                        {
                            await connection.OpenAsync();

                            // Prepare the SQL command with parameters to prevent SQL injection.
                            string sql = @"
                        UPDATE CollectionItem
                        SET Name = @Name,
                            PurchaseDate = @PurchaseDate,
                            PurchasePrice = @PurchasePrice,
                            PurchaseLocation = @PurchaseLocation,
                            SaleDate = @SaleDate,
                            SalePrice = @SalePrice,
                            SaleLocation = @SaleLocation,
                            FrontImageFilePath = @FrontImageFilePath,
                            BackImageFilePath = @BackImageFilePath,
                            Description = @Description,
                            CategoryID = @CategoryID
                        WHERE ID = @ItemID;
                    ";

                            using (SqlCommand command = new SqlCommand(sql, connection))
                            {
                                command.Parameters.AddWithValue("@ItemID", selectedItem); // Get the selected item's ID.
                                command.Parameters.AddWithValue("@Name", txtItemName.Text);
                                command.Parameters.AddWithValue("@PurchaseDate", purchaseDateDateTimePicker.Value);
                                command.Parameters.AddWithValue("@PurchasePrice", decimal.Parse(purchasePriceTextBox.Text));
                                command.Parameters.AddWithValue("@PurchaseLocation", purchaseLocationTextBox.Text);
                                command.Parameters.AddWithValue("@SaleDate", saleDateCheckBox.Checked ? (object)saleDateDateTimePicker.Value : DBNull.Value);
                                command.Parameters.AddWithValue("@SalePrice", string.IsNullOrEmpty(salePriceTextBox.Text) ? (object)DBNull.Value : decimal.Parse(salePriceTextBox.Text));
                                command.Parameters.AddWithValue("@SaleLocation", string.IsNullOrEmpty(saleLocationTextBox.Text) ? (object)DBNull.Value : saleLocationTextBox.Text);
                                command.Parameters.AddWithValue("@FrontImageFilePath", frontImagePath); // Updated image path.
                                command.Parameters.AddWithValue("@BackImageFilePath", backImagePath); // Updated image path.
                                command.Parameters.AddWithValue("@Description", descriptionTextBox.Text);
                                command.Parameters.AddWithValue("@CategoryID", categoryComboBox.SelectedValue);

                                await command.ExecuteNonQueryAsync();
                            }
                            MessageBox.Show("Item updated successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all mandatory fields.");
                }
            }
        }
    }
}
