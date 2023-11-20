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
    public partial class formThirdCategory : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formThirdCategory()
        {
            InitializeComponent();
        }

        private void formThirdCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet5.ThirdCategoriesView' table. You can move, or remove it, as needed.
            this.thirdCategoriesViewTableAdapter.Fill(this.inventoryDBDataSet5.ThirdCategoriesView);
            PopulateComboBox();
            RefreshData();

        }

        private void PopulateComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Brands table
                string query = "SELECT SecondCategoryName FROM SecondCategories";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbSecondCateName.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            // Retrieve the value from the "BrandName" field
                            string SecondCateName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbSecondCateName.Items.Add(SecondCateName);
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

        private void ThirdCategoriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ThirdCategoriesDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = ThirdCategoriesDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    txtThirdCateId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                    txtThirdCateName.Text = selectedRow.Cells[1].Value.ToString();
                    cmbSecondCateName.SelectedItem = selectedRow.Cells[2].Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (ThirdCategoriesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = ThirdCategoriesDataGridView.SelectedRows[0];
            string ThirdCateId = selectedRow.Cells[0].Value.ToString();
            string ThirdCateName = selectedRow.Cells[1].Value.ToString();


            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM ThirdCategories WHERE ThirdCategoryId = '" + int.Parse(ThirdCateId) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                ThirdCategoriesDataGridView.Rows.Remove(selectedRow);
                MessageBox.Show(ThirdCateName + " - Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshData()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM ThirdCategoriesView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            ThirdCategoriesDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["ThirdCategoryId"] = cipher.Decode(row["ThirdCategoryId"].ToString());
                    row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                    row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                }

                // Notify the data grid view that the data has changed
                ThirdCategoriesDataGridView.Refresh();
                txtThirdCateId.Text = "";
                txtThirdCateName.Text = "";
                cmbSecondCateName.SelectedIndex = -1;
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
            if (!string.IsNullOrWhiteSpace(txtThirdCateId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtThirdCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string SecondCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from SecondCategories Where SecondCategoryName = '" + cipher.Encode(cmbSecondCateName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            SecondCateId = Convert.ToString(reader["SecondCategoryId"]);
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
                        string query = "exec UpdateThirdCategory '" + int.Parse(txtThirdCateId.Text) + "','" + cipher.Encode(txtThirdCateName.Text) + "','" + int.Parse(SecondCateId) + "'";
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
                if (string.IsNullOrWhiteSpace(txtThirdCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string SecondCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from SecondCategories Where SecondCategoryName = '" + cipher.Encode(cmbSecondCateName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            SecondCateId = Convert.ToString(reader["SecondCategoryId"]);
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
                        string query = "exec InsertThirdCategory '" + cipher.Encode(txtThirdCateName.Text) + "','" + int.Parse(SecondCateId) + "'";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM ThirdCategoriesView  WHERE ThirdCategoryName LIKE @Keyword OR SecondCategoryName LIKE @Keyword";

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
                            row["ThirdCategoryId"] = cipher.Decode(row["ThirdCategoryId"].ToString());
                            row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                            row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    ThirdCategoriesDataGridView.DataSource = dataTable;
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

        private void btnAddMainCate_Click(object sender, EventArgs e)
        {
            formSecondCategory sc = new formSecondCategory();
            sc.ShowDialog();
        }
    }
}
