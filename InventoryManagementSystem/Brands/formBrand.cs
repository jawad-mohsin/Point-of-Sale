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

namespace InventoryManagementSystem.Category
{
    public partial class formBrand : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formBrand()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PopulateComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Vendors table
                string query = "SELECT VendorName FROM Vendors";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbVendorName.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            // Retrieve the value from the "BrandName" field
                            string VendorName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbVendorName.Items.Add(VendorName);
                        }
                        con.Close();
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void formBrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet7.BrandsView' table. You can move, or remove it, as needed.
            this.brandsViewTableAdapter.Fill(this.inventoryDBDataSet7.BrandsView);
            RefreshData();

        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            Category.formVendors Vendor = new Category.formVendors();
            Vendor.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void BrandsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (BrandsDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = BrandsDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    txtBrandId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                    txtBrandName.Text = selectedRow.Cells[1].Value.ToString();
                    cmbVendorName.Text = selectedRow.Cells[2].Value.ToString();
                    cmbStatus.Text = Convert.ToString(selectedRow.Cells[3].Value);
                    txtBrandDescription.Text = Convert.ToString(selectedRow.Cells[4].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBrandId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtBrandName.Text) ||
                    string.IsNullOrWhiteSpace(cmbVendorName.Text) ||
                    string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtBrandDescription.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string VendorId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from Vendors Where VendorName = '" + cipher.Encode(cmbVendorName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            VendorId = Convert.ToString(reader["VendorId"]);
                        }
                        con.Close();
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        con.Open();
                        string query = "exec UpdateBrand '" + int.Parse(txtBrandId.Text) + "','" + cipher.Encode(txtBrandName.Text) + "','" + int.Parse(VendorId) + "','" + cipher.Encode(txtBrandDescription.Text) + "','" + cipher.Encode(cmbStatus.Text) + "'";
                        SqlCommand command = new SqlCommand(query, con);
                        // Execute the stored procedure
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred: " + ex.Message);
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtBrandName.Text) ||
                    string.IsNullOrWhiteSpace(cmbVendorName.Text) ||
                    string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtBrandDescription.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string VendorId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from Vendors Where VendorName = '" + cipher.Encode(cmbVendorName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            VendorId = Convert.ToString(reader["VendorId"]);
                        }
                        con.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        con.Open();
                        string query = "exec InsertBrand '" + cipher.Encode(txtBrandName.Text) + "','" + int.Parse(VendorId) + "','" + cipher.Encode(txtBrandDescription.Text) + "','" + cipher.Encode(cmbStatus.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void RefreshData()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM BrandsView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            BrandsDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["BrandId"] = cipher.Decode(row["BrandId"].ToString());
                    row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                    row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                    row["BrandDescription"] = cipher.Decode(row["BrandDescription"].ToString());
                    row["BrandStatus"] = cipher.Decode(row["BrandStatus"].ToString());
                }

                // Notify the data grid view that the data has changed
                BrandsDataGridView.Refresh();
                txtBrandId.Text = "";
                txtBrandName.Text = "";
                cmbVendorName.SelectedIndex = -1;
                cmbStatus.SelectedIndex = 0;
                txtBrandDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (BrandsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = BrandsDataGridView.SelectedRows[0];
            string BrandId = selectedRow.Cells[0].Value.ToString();
            string BrandName = selectedRow.Cells[1].Value.ToString();


            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Brands WHERE BrandId = '" + int.Parse(BrandId) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                BrandsDataGridView.Rows.Remove(selectedRow);
                MessageBox.Show(BrandName+" - Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM BrandsView WHERE BrandName LIKE @Keyword OR VendorName LIKE @Keyword OR BrandStatus LIKE @Keyword OR BrandDescription LIKE @Keyword;";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add the search keyword parameter to the command
                    command.Parameters.AddWithValue("@Keyword", "%" + cipher.Encode(keyword) + "%");

                    // Create a DataTable to store the search results
                    DataTable dataTable = new DataTable();

                    // Create a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        // Open the connection
                        con.Open();

                        // Fill the DataTable with the search results
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["BrandId"] = cipher.Decode(row["BrandId"].ToString());
                            row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                            row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                            row["BrandDescription"] = cipher.Decode(row["BrandDescription"].ToString());
                            row["BrandStatus"] = cipher.Decode(row["BrandStatus"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    BrandsDataGridView.DataSource = dataTable;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }
    }
}
