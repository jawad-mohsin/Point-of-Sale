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
    public partial class formVendors : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formVendors()
        {
            InitializeComponent();
            PopulateComboBox();
            con.Close();
        }

        private void PopulateComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Brands table
                string query = "SELECT ThirdCategoryName FROM ThirdCategories";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbThirdCateName.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            // Retrieve the value from the "BrandName" field
                            string ThirdCateName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbThirdCateName.Items.Add(ThirdCateName);
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

        private void btnAddThirdCate_Click(object sender, EventArgs e)
        {
            Category.formThirdCategory ThirdCate = new Category.formThirdCategory();
            ThirdCate.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void formVendors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet6.VendorsView' table. You can move, or remove it, as needed.
            this.vendorsViewTableAdapter.Fill(this.inventoryDBDataSet6.VendorsView);
            RefreshData();

        }

        private void VendosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (VendosDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = VendosDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    txtVendorId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                    txtVendorName.Text = selectedRow.Cells[1].Value.ToString();
                    cmbThirdCateName.Text = selectedRow.Cells[2].Value.ToString();
                    DateTime registerDate = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    dtpRegisterDate.Value = registerDate;
                    cmbStatus.Text = Convert.ToString(selectedRow.Cells[3].Value);
                    txtVendorDesciption.Text = Convert.ToString(selectedRow.Cells[5].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM VendorsView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            VendosDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["VendorId"] = cipher.Decode(row["VendorId"].ToString());
                    row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                    row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                    row["RegisterDate"] = row["RegisterDate"].ToString();
                    row["VendorStatus"] = cipher.Decode(row["VendorStatus"].ToString());
                    row["VendorDescription"] = cipher.Decode(row["VendorDescription"].ToString());
                }

                // Notify the data grid view that the data has changed
                VendosDataGridView.Refresh();
                txtVendorId.Text = "";
                txtVendorName.Text = "";
                cmbThirdCateName.SelectedIndex = -1;
                dtpRegisterDate.Value = DateTime.Now;
                cmbStatus.SelectedIndex = 0;
                txtVendorDesciption.Text = "";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtVendorId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtVendorName.Text) ||
                    string.IsNullOrWhiteSpace(cmbThirdCateName.Text) ||
                    string.IsNullOrWhiteSpace(dtpRegisterDate.Text) ||
                    string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtVendorDesciption.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string ThirdCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from ThirdCategories Where ThirdCategoryName = '" + cipher.Encode(cmbThirdCateName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            ThirdCateId = Convert.ToString(reader["ThirdCategoryId"]);
                        }
                        con.Close();
                        reader.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    try
                    {
                        con.Open();
                        string query = "exec UpdateVendor '" + int.Parse(txtVendorId.Text) + "','" + cipher.Encode(txtVendorName.Text) + "','" + int.Parse(ThirdCateId) + "','"+cipher.Encode(txtVendorDesciption.Text)+"','"+cipher.Encode(cmbStatus.Text)+"','"+dtpRegisterDate.Value.Date+"'";
                        SqlCommand command = new SqlCommand(query, con);
                        // Execute the stored procedure
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error occurred: " + ex.Message);
                        con.Close();
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtVendorName.Text) ||
                    string.IsNullOrWhiteSpace(cmbThirdCateName.Text) ||
                    string.IsNullOrWhiteSpace(dtpRegisterDate.Text) ||
                    string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                    string.IsNullOrWhiteSpace(txtVendorDesciption.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string ThirdCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from ThirdCategories Where ThirdCategoryName = '" + cipher.Encode(cmbThirdCateName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            ThirdCateId = Convert.ToString(reader["ThirdCategoryId"]);
                        }
                        con.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                    try
                    {
                        con.Open();
                        string query = "exec InsertVendor '" + cipher.Encode(txtVendorName.Text) + "','" + int.Parse(ThirdCateId) + "','" + cipher.Encode(txtVendorDesciption.Text) + "','" + cipher.Encode(cmbStatus.Text) + "','" + dtpRegisterDate.Value.Date + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        con.Close();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (VendosDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = VendosDataGridView.SelectedRows[0];
            string VendorId = selectedRow.Cells[0].Value.ToString();
            string VendorName = selectedRow.Cells[1].Value.ToString();


            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Vendors WHERE VendorId = '" + int.Parse(VendorId) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                VendosDataGridView.Rows.Remove(selectedRow);
                MessageBox.Show(VendorName+" - Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "SELECT * FROM VendorsView WHERE VendorName LIKE @Keyword OR ThirdCategoryName LIKE @Keyword OR VendorStatus LIKE @Keyword";

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
                            row["VendorId"] = cipher.Decode(row["VendorId"].ToString());
                            row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                            row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                            row["RegisterDate"] = row["RegisterDate"].ToString();
                            row["VendorStatus"] = cipher.Decode(row["VendorStatus"].ToString());
                            row["VendorDescription"] = cipher.Decode(row["VendorDescription"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    VendosDataGridView.DataSource = dataTable;
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
