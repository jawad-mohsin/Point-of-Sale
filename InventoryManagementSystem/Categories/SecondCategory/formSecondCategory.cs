using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementSystem.Category
{
    public partial class formSecondCategory : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formSecondCategory()
        {
            InitializeComponent();
        }

        private void PopulateComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Brands table
                string query = "SELECT MainCategoryName FROM MainCategories";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbMainCateName.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            string SecondCateName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbMainCateName.Items.Add(SecondCateName);
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

        private void formSecondCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet4.SecondCategoriesView' table. You can move, or remove it, as needed.
            this.secondCategoriesViewTableAdapter.Fill(this.inventoryDBDataSet4.SecondCategoriesView);
            PopulateComboBox();
            RefreshData();
        }

        private void RefreshData()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM SecondCategoriesView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            SecondCategoriesDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["SecondCategoryId"] = cipher.Decode(row["SecondCategoryId"].ToString());
                    row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                    row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());
                }

                // Notify the data grid view that the data has changed
                SecondCategoriesDataGridView.Refresh();
                txtSecondCateId.Text = "";
                txtSecondCateName.Text = "";
                cmbMainCateName.SelectedIndex = -1;
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

        private void SecondCategoriesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (SecondCategoriesDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = SecondCategoriesDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    txtSecondCateId.Text = Convert.ToString(selectedRow.Cells[0].Value);
                    txtSecondCateName.Text = selectedRow.Cells[1].Value.ToString();
                    cmbMainCateName.SelectedItem = selectedRow.Cells[2].Value;



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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtSecondCateId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtSecondCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string MainCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from MainCategories Where MainCategoryName = '"+cipher.Encode(cmbMainCateName.Text)+"'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MainCateId = Convert.ToString(reader["MainCategoryId"]);
                        }
                        con.Close();
                        reader.Close();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        con.Open();
                        string query = "exec UpdateSecondCategory '" + int.Parse(txtSecondCateId.Text) + "','" + cipher.Encode(txtSecondCateName.Text) + "','"+int.Parse(MainCateId)+"'";
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
                if (string.IsNullOrWhiteSpace(txtSecondCateName.Text))
                {
                    MessageBox.Show("Please Fill Correct Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    string MainCateId = "";
                    try
                    {
                        con.Open();
                        string query = "Select * from MainCategories Where MainCategoryName = '" + cipher.Encode(cmbMainCateName.Text) + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MainCateId = Convert.ToString(reader["MainCategoryId"]);
                        }
                        con.Close();
                        reader.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try
                    {
                        con.Open();
                        string query = "exec InsertSecondCategory '" + cipher.Encode(txtSecondCateName.Text) + "','"+int.Parse(MainCateId)+"'";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (SecondCategoriesDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = SecondCategoriesDataGridView.SelectedRows[0];
            string SecondCateId = selectedRow.Cells[0].Value.ToString();
            string SecondCateName = selectedRow.Cells[1].Value.ToString();


            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("DELETE FROM SecondCategories WHERE SecondCategoryId = '" + int.Parse(SecondCateId) + "'", con);
                command.ExecuteNonQuery();
                con.Close();
                SecondCategoriesDataGridView.Rows.Remove(selectedRow);
                MessageBox.Show(SecondCateName+" - Sucessfully Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "SELECT * FROM SecondCategoriesView  WHERE SecondCategoryName LIKE @Keyword OR MainCategoryName LIKE @Keyword";

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
                            row["SecondCategoryId"] = cipher.Decode(row["SecondCategoryId"].ToString());
                            row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                            row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    SecondCategoriesDataGridView.DataSource = dataTable;
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
            formMainCategory mc = new formMainCategory();
            mc.ShowDialog();
        }
    }
}
