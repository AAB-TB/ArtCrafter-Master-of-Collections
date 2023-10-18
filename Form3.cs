using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtCrafter.MasterofCollections
{
    public partial class Form3 : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        string connectionString = "Data Source=ALVIN-AB\\SQLEXPRESS;Initial Catalog=\"ArtCrafter: Master of Collections\";Integrated Security=True";

        CollectionItem selectedCollectionItem;
        public Form3(int selectedCollectionItemID)
        {
            InitializeComponent();

            LoadCollectionItemDetails(selectedCollectionItemID);


        }
        private void LoadCollectionItemDetails(int selectedCollectionItemID)
        {
            // Retrieve the selected collection item details
            selectedCollectionItem = RetrieveCollectionItemDetailsFromDatabase(selectedCollectionItemID);

            // Check if a valid collection item was found
            if (selectedCollectionItem != null)
            {
                itemTitle.Text = selectedCollectionItem.Name;
                itemDescription.Text = selectedCollectionItem.Description;
                purchaseLocation.Text = selectedCollectionItem.PurchaseLocation;

                // Display PurchaseDate and SaleDate in TextBoxes with date format only
                purchaseDate.Text = selectedCollectionItem.PurchaseDate?.ToShortDateString() ?? string.Empty;
                sellDate.Text = selectedCollectionItem.SaleDate?.ToShortDateString() ?? string.Empty;

                // Set Purchase Price, Sale Price, and other TextBox values
                purchasePrice.Text = selectedCollectionItem.PurchasePrice?.ToString() ?? string.Empty;
                sellLocation.Text = selectedCollectionItem.SaleLocation;
                sellPrice.Text = selectedCollectionItem.SalePrice?.ToString() ?? string.Empty;

                // Load front and back images from file paths
                if (!string.IsNullOrEmpty(selectedCollectionItem.FrontImageFilePath))
                {
                    frontsidePictureBox.Image = Image.FromFile(selectedCollectionItem.FrontImageFilePath);
                }
                if (!string.IsNullOrEmpty(selectedCollectionItem.BackImageFilePath))
                {
                    backsidePictureBox.Image = Image.FromFile(selectedCollectionItem.BackImageFilePath);
                }
            }
            else
            {
                // Handle the case where the selected collection item doesn't exist or an error occurred.
                // You might want to display an error message or clear the UI controls.
            }
        }



        private CollectionItem RetrieveCollectionItemDetailsFromDatabase(int collectionItemID)
        {
            string query = @"
    SELECT
        ID, Name, PurchaseDate, PurchasePrice, PurchaseLocation,
        SaleDate, SalePrice, SaleLocation, FrontImageFilePath, BackImageFilePath, Description, CategoryID
    FROM CollectionItem
    WHERE ID = @CollectionItemID
    ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@CollectionItemID", collectionItemID);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read(); // Since there should be only one matching record

                        CollectionItem collectionItem = new CollectionItem
                        {
                            ID = reader.IsDBNull(0) ? (int?)null : reader.GetInt32(0),
                            Name = reader.GetString(1),
                            PurchaseDate = reader.GetDateTime(2),
                            PurchasePrice = reader.GetDecimal(3),
                            PurchaseLocation = reader.GetString(4),
                            SaleDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
                            SalePrice = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6),
                            SaleLocation = reader.IsDBNull(7) ? null : reader.GetString(7),
                            FrontImageFilePath = reader.IsDBNull(8) ? null : reader.GetString(8),
                            BackImageFilePath = reader.IsDBNull(9) ? null : reader.GetString(9),
                            Description = reader.IsDBNull(10) ? null : reader.GetString(10),
                            CategoryID = reader.IsDBNull(11) ? (int?)null : reader.GetInt32(11)
                        };

                        return collectionItem;
                    }
                    else
                    {
                        // Handle the case where no matching collection item is found, e.g., display an error message or return null.
                        // You may want to log this situation for debugging.
                        logger.Error($"CollectionItem with ID {collectionItemID} not found in the database.");
                    }
                }
            }

            // Handle any other errors here.
            return null;
        }

        private void hemBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void takeForm2Btn_Click(object sender, EventArgs e)
        {
            if (selectedCollectionItem != null)
            {
                int id = (int)selectedCollectionItem.ID;
                Form2 form2 = new Form2(id); // Pass the ID to Form2
                form2.Show();
                this.Hide();
            }
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {



            if (selectedCollectionItem == null)
            {
                MessageBox.Show("No collection item is selected for deletion.");
                return;
            }

            // Confirm the deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this collection item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteCollectionItem(selectedCollectionItem.ID);


                    ClearForm();
                }
                catch (Exception ex)
                {
                    logger.Error("Collection Item Deletion", ex);
                }
            }
        }
        private async void DeleteCollectionItem(int? collectionItemID)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Delete the collection item
                        string deleteCollectionItemQuery = "DELETE FROM CollectionItem WHERE ID = @CollectionItemID";
                        using (SqlCommand deleteCollectionItemCmd = new SqlCommand(deleteCollectionItemQuery, connection, transaction))
                        {
                            deleteCollectionItemCmd.Parameters.AddWithValue("@CollectionItemID", collectionItemID);
                            await deleteCollectionItemCmd.ExecuteNonQueryAsync();
                        }

                        transaction.Commit();
                        MessageBox.Show("Collection item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm(); // Clear the form
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Failed to delete the collection item. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error(ex, "Error deleting the collection item.");
                    }
                }
            }
        }

        private void ClearForm()
        {
            // Clear all the TextBoxes, PictureBoxes, etc., to reset the form
            itemTitle.Text = "";
            itemDescription.Text = "";
            purchaseLocation.Text = "";
            purchaseDate.Text = "";
            sellDate.Text = "";
            purchasePrice.Text = "";
            sellLocation.Text = "";
            sellPrice.Text = "";
            frontsidePictureBox.Image = null;
            backsidePictureBox.Image = null;

            // You can also set other default values or clear any other controls you have on the form.
        }

    }
}
