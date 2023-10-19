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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ArtCrafter.MasterofCollections
{
    public partial class Form4 : Form
    {
        string connectionString = "Data Source=ALVIN-AB\\SQLEXPRESS;Initial Catalog=\"ArtCrafter: Master of Collections\";Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
            PopulateLocationComboBox();
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

        private void generaterp_Click(object sender, EventArgs e)
        {
            DateTime fromDate = fromdatetimepicker.Value;
            DateTime tillDate = tilldatetimepicker.Value;

            decimal totalBuyingCost = 0;
            decimal totalSellingCost = 0;

            // Query the database to retrieve data within the specified date range
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT ISNULL(PurchasePrice, 0), ISNULL(SalePrice, 0), PurchaseDate FROM CollectionItem";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        decimal purchasePrice = reader.GetDecimal(0); // Assuming PurchasePrice is in the first column
                        decimal salePrice = reader.GetDecimal(1); // Assuming SalePrice is in the second column
                        DateTime itemDate = reader.GetDateTime(2); // Assuming PurchaseDate is in the third column

                        // Check if the itemDate is within the specified date range
                        if (itemDate.Date >= fromDate.Date && itemDate.Date <= tillDate.Date)
                        {
                            totalBuyingCost += purchasePrice;
                            totalSellingCost += salePrice;
                        }
                    }
                }
            }

            decimal profitOrLoss = totalSellingCost - totalBuyingCost;

            // Display the results in text boxes
            totalBuyingCostTextBox.Text = totalBuyingCost.ToString();
            totalSellingCostTextBox.Text = totalSellingCost.ToString();
            totalProfitLossTextBox.Text = profitOrLoss.ToString();

            // Change text color based on profit or loss
            totalProfitLossTextBox.ForeColor = profitOrLoss >= 0 ? Color.Green : Color.Red;
        }
        private void PopulateLocationComboBox()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT DISTINCT SaleLocation FROM CollectionItem WHERE SaleLocation IS NOT NULL " +
                               "UNION SELECT DISTINCT PurchaseLocation FROM CollectionItem WHERE PurchaseLocation IS NOT NULL";

                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string location = reader.IsDBNull(0) ? "N/A" : reader.GetString(0);
                        locationComboBox.Items.Add(location);
                    }
                }
            }
        }

        private void generateRPbtn_Click(object sender, EventArgs e)
        {
            string selectedLocation = locationComboBox.SelectedItem.ToString();
            DateTime fromDate = fromDateTimePicker2.Value.Date;
            DateTime tillDate = tillDateTimePicker2.Value.Date;

            decimal totalBuyingCost = 0;
            decimal totalSellingCost = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string purchaseQuery = "SELECT ISNULL(PurchasePrice, 0) FROM CollectionItem " +
                                       "WHERE PurchaseLocation = @Location " +
                                       "AND (PurchaseDate >= @FromDate AND PurchaseDate <= @TillDate)";

                string saleQuery = "SELECT ISNULL(SalePrice, 0) FROM CollectionItem " +
                                   "WHERE SaleLocation = @Location " +
                                   "AND (PurchaseDate >= @FromDate AND PurchaseDate <= @TillDate)";

                SqlCommand purchaseCommand = new SqlCommand(purchaseQuery, connection);
                SqlCommand saleCommand = new SqlCommand(saleQuery, connection);

                purchaseCommand.Parameters.AddWithValue("@Location", selectedLocation);
                saleCommand.Parameters.AddWithValue("@Location", selectedLocation);
                purchaseCommand.Parameters.AddWithValue("@FromDate", fromDate);
                saleCommand.Parameters.AddWithValue("@FromDate", fromDate);
                purchaseCommand.Parameters.AddWithValue("@TillDate", tillDate);
                saleCommand.Parameters.AddWithValue("@TillDate", tillDate);

                totalBuyingCost = CalculateTotalCost(purchaseCommand);
                totalSellingCost = CalculateTotalCost(saleCommand);
            }

            decimal profitOrLoss = totalSellingCost - totalBuyingCost;

            totalBuyingCostBox.Text = totalBuyingCost.ToString();
            totalSellingCostBox.Text = totalSellingCost.ToString();
            totalProfitLossBox.Text = profitOrLoss.ToString();

            totalProfitLossBox.ForeColor = profitOrLoss >= 0 ? Color.Green : Color.Red;
        }

        private decimal CalculateTotalCost(SqlCommand command)
        {
            decimal totalCost = 0;
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    decimal cost = reader.GetDecimal(0);
                    totalCost += cost;
                }
            }
            return totalCost;
        }

        private void resetbtn1_Click(object sender, EventArgs e)
        {
            totalBuyingCostTextBox.Text = "";
            totalSellingCostTextBox.Text = "";
            totalProfitLossTextBox.Text = "";

        }

        private void resetbtn2_Click(object sender, EventArgs e)
        {
            totalBuyingCostBox.Text = "";
            totalSellingCostBox.Text = "";
            totalProfitLossBox.Text = "";

            locationComboBox.SelectedItem = null;
        }
    }

}
