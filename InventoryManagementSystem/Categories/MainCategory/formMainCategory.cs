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
    public partial class formMainCategory : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formMainCategory()
        {
            InitializeComponent();
        }

        private void formMainCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet3.MainCategories' table. You can move, or remove it, as needed.
            this.mainCategoriesTableAdapter.Fill(this.inventoryDBDataSet3.MainCategories);
            // TODO: This line of code loads data into the 'inventoryDBDataSet3.MainCategories' table. You can move, or remove it, as needed.
            this.mainCategoriesTableAdapter.Fill(this.inventoryDBDataSet3.MainCategories);
            Refresh();
            con.Close();

        }

        private void MainCategoriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (MainCategoriesDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = MainCategoriesDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    int MainCateId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string MainCateName = Convert.ToString(selectedRow.Cells[1].Value);
                    // Populate the input fields
                    txtMainCateId.Text = MainCateId.ToString();
                    txtMainCateName.Text = MainCateName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }


        private void Refresh()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM MainCategories", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            MainCategoriesDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["MainCategoryId"] = cipher.Decode(row["MainCategoryId"].ToString());
                    row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());
                }

                // Notify the data grid view that the data has changed
                MainCategoriesDataGridView.Refresh();
                txtMainCateId.Text = "";
                txtMainCateName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            txtMainCateId.Text = "";
            txtMainCateName.Text = "";
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMainCateId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtMainCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        con.Open();
                        string query = "exec UpdateMainCategory '"+int.Parse(txtMainCateId.Text)+"','"+cipher.Encode(txtMainCateName.Text)+"'";
                        SqlCommand command = new SqlCommand(query,con);
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
                if (string.IsNullOrWhiteSpace(txtMainCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    con.Open();
                    string query = "exec InsertMainCategory '" + cipher.Encode(txtMainCateName.Text) + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
                
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (MainCategoriesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = MainCategoriesDataGridView.SelectedRows[0];

            // Get the UserId (primary key) value from the selected row
            string MainCateId = selectedRow.Cells[0].Value.ToString();
            string MainCateName = selectedRow.Cells[1].Value.ToString();
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM MainCategories WHERE MainCategoryId = '" + int.Parse(MainCateId) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                MainCategoriesDataGridView.Rows.Remove(selectedRow);
                MessageBox.Show(MainCateName + " - Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "SELECT * FROM MainCategories WHERE MainCategoryName LIKE @Keyword";

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
                            row["MainCategoryId"] = cipher.Decode(row["MainCategoryId"].ToString());
                            row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    MainCategoriesDataGridView.DataSource = dataTable;
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
