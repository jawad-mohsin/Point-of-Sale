using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using DevExpress.Map.Kml.Model;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    public partial class formDashboard : Form
    {
        Cipher cipher = new Cipher();
        public SqlDataAdapter dataAdapter;
        public DataTable dataTable;
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        public formDashboard(string username,string role)
        {
            InitializeComponent();
            lblRole.Text = role;
            lblUserName.Text = username;
            if (role == "Cashier")
            {
                btnMasterusers.Enabled = false;
                btnMasterusers.Visible = false;
                btnMastercategories.Enabled = false;
                btnMastercategories.Visible = false;
                btnSellinghistory.Location = new System.Drawing.Point(10, 324);
                btnDashboard.Location = new System.Drawing.Point(10, 158);
                btnmakesales.Location = new System.Drawing.Point(10, 214);
                btnAllstocks.Location = new System.Drawing.Point(10, 269);
                sideBar.Height = btnDashboard.Height;
                sideBar.Top = btnDashboard.Top;
                Usersbox.Visible = false;
                SalaryBox.Visible = false;
                guna2Panel14.Visible = false;
                stockbox.Location = new System.Drawing.Point(365, 156);
                salesboxheading.Location = new System.Drawing.Point(30, 156);
                guna2Panel2.Location = new System.Drawing.Point(30, 198);
                salesboxbutton.Location = new System.Drawing.Point(30, 360);
                CategoryBox.Location = new System.Drawing.Point(681, 156);
                guna2Panel15.Location = new System.Drawing.Point(681, 351);

            }
            else if(role == "Salesman")
            {
                btnMasterusers.Enabled = false;
                btnMasterusers.Visible = false;
                btnMastercategories.Enabled = false;
                btnMastercategories.Visible = false;
                btnAllstocks.Enabled = false;
                btnAllstocks.Visible = false;
                btnDashboard.Location = new System.Drawing.Point(10, 158);
                btnmakesales.Location = new System.Drawing.Point(10, 214);
                btnSellinghistory.Location = new System.Drawing.Point(10, 269);
                sideBar.Height = btnDashboard.Height;
                sideBar.Top = btnDashboard.Top;
                Usersbox.Visible = false;
                SalaryBox.Visible = false;
                guna2Panel14.Visible = false;
                stockbox.Location = new System.Drawing.Point(365, 156);
                salesboxheading.Location = new System.Drawing.Point(30, 156);
                guna2Panel2.Location = new System.Drawing.Point(30, 198);
                salesboxbutton.Location = new System.Drawing.Point(30, 360);
                CategoryBox.Location = new System.Drawing.Point(681, 156);
                guna2Panel15.Location = new System.Drawing.Point(681, 351);
            }
        }

        private void LoadDashboard()
        {
            LoadSalesData();
            LoadStockData();
            LoadUsersData();
            LoadSalariesData();
            LoadCategoriesData();
        }

        private void LoadSalesData()
        {
            con.Open();

            // Sales today
            string queryToday = "SELECT COUNT(*) FROM Orders WHERE CONVERT(DATE, PaymentDate) = CONVERT(DATE, GETDATE())";
            SqlCommand commandToday = new SqlCommand(queryToday, con);
            int salesToday = (int)commandToday.ExecuteScalar();
            lblLastDaySell.Text = salesToday.ToString();
            // Sales in the last 7 days
            string queryLast7Days = "SELECT COUNT(*) FROM Orders WHERE PaymentDate >= DATEADD(DAY, -7, GETDATE())";
            SqlCommand commandLast7Days = new SqlCommand(queryLast7Days, con);
            int salesLast7Days = (int)commandLast7Days.ExecuteScalar();
            lblLast7DaySell.Text = salesLast7Days.ToString();

            // Sales in the last 30 days
            string queryLast30Days = "SELECT COUNT(*) FROM Orders WHERE PaymentDate >= DATEADD(DAY, -30, GETDATE())";
            SqlCommand commandLast30Days = new SqlCommand(queryLast30Days, con);
            int salesLast30Days = (int)commandLast30Days.ExecuteScalar();
            lblLast30DaySell.Text = salesLast30Days.ToString();

            // Total sales
            string queryTotalSales = "SELECT COUNT(*) FROM Orders";
            SqlCommand commandTotalSales = new SqlCommand(queryTotalSales, con);
            int totalSales = (int)commandTotalSales.ExecuteScalar();
            lblLastTotalSell.Text = totalSales.ToString();
            con.Close();
        }

        private void LoadStockData()
        {
            string available = cipher.Encode("Available");
            con.Open();
            string queryAvailableStock = "SELECT COUNT(*) FROM Products WHERE ProductStatus = '"+available+"'";
            SqlCommand commandAvailableStock = new SqlCommand(queryAvailableStock, con);
            int availableStock = (int)commandAvailableStock.ExecuteScalar();
            lblAvailableStock.Text = availableStock.ToString();

            // Total stock
            string queryTotalStock = "SELECT COUNT(*) FROM Products";
            SqlCommand commandTotalStock = new SqlCommand(queryTotalStock, con);
            int totalStock = (int)commandTotalStock.ExecuteScalar();
            lblTotalStock.Text = totalStock.ToString();

            // Not available stock
            lblNotAvailableStock.Text = (totalStock - availableStock).ToString();

            con.Close();
        }

        private void LoadUsersData()
        {
            con.Open();
            string queryAdmins = "SELECT COUNT(*) FROM Users WHERE Role = '"+cipher.Encode("Admin")+"'";
            SqlCommand commandAdmins = new SqlCommand(queryAdmins, con);
            int adminsCount = (int)commandAdmins.ExecuteScalar();
            lblTotalAdmin.Text = adminsCount.ToString();
            // Number of cashiers
            string queryCashiers = "SELECT COUNT(*) FROM Users WHERE Role = '" + cipher.Encode("Cashier") + "'";
            SqlCommand commandCashiers = new SqlCommand(queryCashiers, con);
            int cashiersCount = (int)commandCashiers.ExecuteScalar();
            lblTotalCashier.Text = cashiersCount.ToString();

            // Number of salesmans
            string querySalesmans = "SELECT COUNT(*) FROM Users WHERE Role = '" + cipher.Encode("Salesman") + "'";
            SqlCommand commandSalesmans = new SqlCommand(querySalesmans, con);
            int salesmansCount = (int)commandSalesmans.ExecuteScalar();
            lblTotalSalesMan.Text = salesmansCount.ToString();

            //Total users
            lblTotalUser.Text = (adminsCount + cashiersCount + salesmansCount).ToString();
            con.Close();
        }

        private void LoadSalariesData()
        {
            con.Open();
            // Sum of all admin salaries
            string queryAdminSalaries = "SELECT SUM(Salary) FROM Users WHERE Role = '" + cipher.Encode("Admin") + "'";
            SqlCommand commandAdminSalaries = new SqlCommand(queryAdminSalaries, con);
            Int64 adminSalariesSum = (Int64)commandAdminSalaries.ExecuteScalar();
            lblAdminTotalSal.Text = (adminSalariesSum.ToString() + " PKR");
            // Sum of all cashier salaries
            string queryCashierSalaries = "SELECT SUM(Salary) FROM Users WHERE Role = '" + cipher.Encode("Cashier") + "'";
            SqlCommand commandCashierSalaries = new SqlCommand(queryCashierSalaries, con);
            Int64 cashierSalariesSum = (Int64)commandCashierSalaries.ExecuteScalar();
            lblCashierTotalSal.Text = (cashierSalariesSum.ToString() + " PKR");

            // Sum of all salesman salaries
            string querySalesmanSalaries = "SELECT SUM(Salary) FROM Users WHERE Role = '" + cipher.Encode("Salesman") + "'";
            SqlCommand commandSalesmanSalaries = new SqlCommand(querySalesmanSalaries, con);
            Int64 salesmanSalariesSum = (Int64)commandSalesmanSalaries.ExecuteScalar();
            lblSalesManTotalSal.Text = (salesmanSalariesSum.ToString() + " PKR");

            //Total Salaries
            lblTotalSal.Text = ((adminSalariesSum + cashierSalariesSum + salesmanSalariesSum).ToString() + " PKR");

            con.Close();
        }

        private void LoadCategoriesData()
        {
            con.Open();
            // Number of main categories
            string queryMainCategories = "SELECT COUNT(*) FROM MainCategories";
            SqlCommand commandMainCategories = new SqlCommand(queryMainCategories, con);
            int mainCategoriesCount = (int)commandMainCategories.ExecuteScalar();
            lblTotalMC.Text = mainCategoriesCount.ToString();
            // Number of second categories
            string querySecondCategories = "SELECT COUNT(*) FROM SecondCategories";
            SqlCommand commandSecondCategories = new SqlCommand(querySecondCategories, con);
            int secondCategoriesCount = (int)commandSecondCategories.ExecuteScalar();
            lblTotalSC.Text = secondCategoriesCount.ToString();

            // Number of third categories
            string queryThirdCategories = "SELECT COUNT(*) FROM ThirdCategories";
            SqlCommand commandThirdCategories = new SqlCommand(queryThirdCategories, con);
            int thirdCategoriesCount = (int)commandThirdCategories.ExecuteScalar();
            lblTotalTH.Text = thirdCategoriesCount.ToString();

            // Number of brands
            string queryBrands = "SELECT COUNT(*) FROM Brands";
            SqlCommand commandBrands = new SqlCommand(queryBrands, con);
            int brandsCount = (int)commandBrands.ExecuteScalar();
            lblTotalBR.Text = brandsCount.ToString();

            // Number of vendors
            string queryVendors = "SELECT COUNT(*) FROM Vendors";
            SqlCommand commandVendors = new SqlCommand(queryVendors, con);
            int vendorsCount = (int)commandVendors.ExecuteScalar();
            lblTotalVN.Text = vendorsCount.ToString();
            con.Close();
        }

        private void RefreshCart()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM ProductsView", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            CartDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["ProductId"] = cipher.Decode(row["ProductId"].ToString());
                    row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                    row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                    row["ProductStatus"] = cipher.Decode(row["ProductStatus"].ToString());
                }

                // Notify the data grid view that the data has changed
                CartDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshProducts()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM ProductView", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            ProductsDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["ProductId"] = cipher.Decode(row["ProductId"].ToString());
                    row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                    row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                    row["ProductStatus"] = cipher.Decode(row["ProductStatus"].ToString());
                    row["ProductDescription"] = cipher.Decode(row["ProductDescription"].ToString());
                }

                // Notify the data grid view that the data has changed
                ProductsDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshMasterCategories()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM MasterView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            MasterCategoriesDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                    row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                    row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                    row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                    row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                    row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            // Click Effect
            sideBar.Height = btnDashboard.Height;
            sideBar.Top = btnDashboard.Top;
            // Functions
            MainTabControl.SelectedIndex = 0;
            this.Text = "IMS : Dashboard";
        }

        private void btnmakesales_Click(object sender, EventArgs e)
        {
            RefreshCart();
            sideBar.Height = btnmakesales.Height;
            sideBar.Top = btnmakesales.Top;

            // Functions
            MainTabControl.SelectedIndex = 5;
            this.Text = "IMS : Make Sales";
        }

        private void btnAllstocks_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnAllstocks.Height;
            sideBar.Top = btnAllstocks.Top;

            // Functions
            MainTabControl.SelectedIndex = 2;
            RefreshProducts();
            this.Text = "IMS : All Stock";

        }

        private void btnMastercategories_Click(object sender, EventArgs e)
        {
            // Click Effect
            sideBar.Height = btnMastercategories.Height;
            sideBar.Top = btnMastercategories.Top;

            // Functions
            MainTabControl.SelectedIndex = 4;
            RefreshMasterCategories();
            this.Text = "IMS : Master Categories";

        }

        private void btnMasterusers_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnMasterusers.Height;
            sideBar.Top = btnMasterusers.Top;

            // Functions
            MainTabControl.SelectedIndex = 1;
            this.Text = "IMS : Master Users";
        }

        private void btnSellinghistory_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnSellinghistory.Height;
            sideBar.Top = btnSellinghistory.Top;

            // Functions
            MainTabControl.SelectedIndex = 3;
            RefreshSalesHistory();
            this.Text = "IMS : Selling History";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login.Login login = new Login.Login();
            login.ShowDialog();
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet12.ProductView' table. You can move, or remove it, as needed.
            this.productViewTableAdapter.Fill(this.inventoryDBDataSet12.ProductView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet11.SalesHistoryView' table. You can move, or remove it, as needed.
            this.salesHistoryViewTableAdapter.Fill(this.inventoryDBDataSet11.SalesHistoryView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet10.ProductsView' table. You can move, or remove it, as needed.
            this.productsViewTableAdapter1.Fill(this.inventoryDBDataSet10.ProductsView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet9.ProductsView' table. You can move, or remove it, as needed.
            this.productsViewTableAdapter.Fill(this.inventoryDBDataSet9.ProductsView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet8.MasterView' table. You can move, or remove it, as needed.
            this.masterViewTableAdapter.Fill(this.inventoryDBDataSet8.MasterView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet2.CartView' table. You can move, or remove it, as needed.
            this.cartViewTableAdapter.Fill(this.inventoryDBDataSet2.CartView);
            // TODO: This line of code loads data into the 'inventoryDBDataSet21.CartView' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'inventoryDBDataSet2.CartView' table. You can move, or remove it, as needed.
            DisplayUserData();
            PopulateBrandComboBox();
            PopulateUserNameComboBox();
            RefreshMasterCategories();
            RefreshProducts();
            RefreshCart();
            RefreshSalesHistory();
            LoadDashboard();
            int rowCount = SalesHistoryDataGridView.Rows.Count;
            lblTotalSalesHistory.Text = rowCount.ToString();
            int rowCount1 = CartDataGridView.Rows.Count;
            lblTotalProducts.Text = rowCount1.ToString();
            con.Close();
            // TODO: This line of code loads data into the 'inventoryDBDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.inventoryDBDataSet1.Products);
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.inventoryDBDataSet.Users);

        }

        private void UsersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = UsersDataGridView.Rows[e.RowIndex];

                    // Retrieve the data from the selected row
                    int userId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string userName = selectedRow.Cells[1].Value.ToString();
                    string firstName = selectedRow.Cells[2].Value.ToString();
                    string lastName = selectedRow.Cells[3].Value.ToString();
                    string password = selectedRow.Cells[4].Value.ToString();
                    string email = selectedRow.Cells[5].Value.ToString();
                    DateTime birthdate = Convert.ToDateTime(selectedRow.Cells[6].Value);
                    int age = Convert.ToInt32(selectedRow.Cells[7].Value);
                    string gender = selectedRow.Cells[8].Value.ToString();
                    string role = selectedRow.Cells[9].Value.ToString();
                    long salary = Convert.ToInt64(selectedRow.Cells[10].Value);
                    DateTime joinDate = Convert.ToDateTime(selectedRow.Cells[11].Value);
                    string nid = selectedRow.Cells[12].Value.ToString();
                    long phone = Convert.ToInt64(selectedRow.Cells[13].Value);
                    string address = selectedRow.Cells[14].Value.ToString();
                    string currentCity = selectedRow.Cells[15].Value.ToString();
                    string bloodGroup = selectedRow.Cells[16].Value.ToString();

                    // Populate the respective input fields with the retrieved data
                    txtUserId.Text = userId.ToString();
                    txtUsername.Text = userName;
                    txtFirstName.Text = firstName;
                    txtLastName.Text = lastName;
                    txtPassword.Text = password;
                    txtEmail.Text = email;
                    dtpBirthDate.Value = birthdate;
                    txtAge.Text = age.ToString();
                    cmbGender.SelectedItem = gender;
                    cmbRole.SelectedItem = role;
                    txtSalary.Text = salary.ToString();
                    dtpJoinDate.Value = joinDate;
                    txtNID.Text = nid;
                    txtPhone.Text = phone.ToString();
                    txtAddress.Text = address;
                    txtCurrentCity.Text = currentCity;
                    cmbBloodGroup.SelectedItem = bloodGroup;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(dtpBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(dtpJoinDate.Text) ||
                string.IsNullOrWhiteSpace(txtNID.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtCurrentCity.Text) ||
                string.IsNullOrWhiteSpace(cmbBloodGroup.Text))
                {
                    MessageBox.Show("Please Fill Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    using (SqlCommand command = new SqlCommand("UpdateUser", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@UserId", Convert.ToInt32(cipher.Encode(txtUserId.Text)));
                        command.Parameters.AddWithValue("@UserName", cipher.Encode(txtUsername.Text));
                        command.Parameters.AddWithValue("@FirstName", cipher.Encode(txtFirstName.Text));
                        command.Parameters.AddWithValue("@LastName", cipher.Encode(txtLastName.Text));
                        command.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                        command.Parameters.AddWithValue("@Email", cipher.Encode(txtEmail.Text));
                        command.Parameters.AddWithValue("@Birthdate", dtpBirthDate.Value.Date);
                        command.Parameters.AddWithValue("@Age", Convert.ToInt32(cipher.Encode(txtAge.Text)));
                        command.Parameters.AddWithValue("@Gender", cipher.Encode((cmbGender.Text)));
                        command.Parameters.AddWithValue("@Role", cipher.Encode(cmbRole.Text));
                        command.Parameters.AddWithValue("@Salary", Convert.ToInt64(cipher.Encode(txtSalary.Text)));
                        command.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value.Date);
                        command.Parameters.AddWithValue("@NID", cipher.Encode(txtNID.Text));
                        command.Parameters.AddWithValue("@Phone", Convert.ToInt64(cipher.Encode(txtPhone.Text)));
                        command.Parameters.AddWithValue("@Address", cipher.Encode(txtAddress.Text));
                        command.Parameters.AddWithValue("@CurrentCity", cipher.Encode(txtCurrentCity.Text));
                        command.Parameters.AddWithValue("@BloodGroup", cipher.Encode(cmbBloodGroup.Text));

                        // Open the connection
                        con.Open();

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(dtpBirthDate.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbRole.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                string.IsNullOrWhiteSpace(dtpJoinDate.Text) ||
                string.IsNullOrWhiteSpace(txtNID.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtCurrentCity.Text) ||
                string.IsNullOrWhiteSpace(cmbBloodGroup.Text))
                {
                    MessageBox.Show("Please Fill Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Save data to the database
                try
                {
                    using (SqlCommand command = new SqlCommand("InsertUser", con))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        command.Parameters.AddWithValue("@UserId", Convert.ToInt32(cipher.Encode(txtUserId.Text)));
                        command.Parameters.AddWithValue("@UserName", cipher.Encode(txtUsername.Text));
                        command.Parameters.AddWithValue("@FirstName", cipher.Encode(txtFirstName.Text));
                        command.Parameters.AddWithValue("@LastName", cipher.Encode(txtLastName.Text));
                        command.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                        command.Parameters.AddWithValue("@Email", cipher.Encode(txtEmail.Text));
                        command.Parameters.AddWithValue("@Birthdate", dtpBirthDate.Value.Date);
                        command.Parameters.AddWithValue("@Age", Convert.ToInt32(cipher.Encode(txtAge.Text)));
                        command.Parameters.AddWithValue("@Gender", cipher.Encode((cmbGender.Text)));
                        command.Parameters.AddWithValue("@Role", cipher.Encode(cmbRole.Text));
                        command.Parameters.AddWithValue("@Salary", Convert.ToInt64(cipher.Encode(txtSalary.Text)));
                        command.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value.Date);
                        command.Parameters.AddWithValue("@NID", cipher.Encode(txtNID.Text));
                        command.Parameters.AddWithValue("@Phone", Convert.ToInt64(cipher.Encode(txtPhone.Text)));
                        command.Parameters.AddWithValue("@Address", cipher.Encode(txtAddress.Text));
                        command.Parameters.AddWithValue("@CurrentCity", cipher.Encode(txtCurrentCity.Text));
                        command.Parameters.AddWithValue("@BloodGroup", cipher.Encode(cmbBloodGroup.Text));

                        // Open the connection
                        con.Open();

                        // Execute the stored procedure
                        command.ExecuteNonQuery();

                        MessageBox.Show("Data Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DisplayUserData()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM Users", con);
            dataTable = new DataTable();

            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["UserId"] = cipher.Decode(row["UserId"].ToString());
                    row["UserName"] = cipher.Decode(row["UserName"].ToString());
                    row["FirstName"] = cipher.Decode(row["FirstName"].ToString());
                    row["LastName"] = cipher.Decode(row["LastName"].ToString());
                    row["Password"] = cipher.Decode(row["Password"].ToString());
                    row["Email"] = cipher.Decode(row["Email"].ToString());
                    row["Birthdate"] = row["Birthdate"].ToString();
                    row["Age"] = cipher.Decode(row["Age"].ToString());
                    row["Gender"] = cipher.Decode(row["Gender"].ToString());
                    row["Role"] = cipher.Decode(row["Role"].ToString());
                    row["Salary"] = cipher.Decode(row["Salary"].ToString());
                    row["JoinDate"] = row["JoinDate"].ToString();
                    row["NID"] = cipher.Decode(row["NID"].ToString());
                    row["Phone"] = cipher.Decode(row["Phone"].ToString());
                    row["Address"] = cipher.Decode(row["Address"].ToString());
                    row["CurrentCity"] = cipher.Decode(row["CurrentCity"].ToString());
                    row["BloodGroup"] = cipher.Decode(row["BloodGroup"].ToString());
                }

                // Bind the data table to the data grid view
                UsersDataGridView.DataSource = dataTable;
                // Notify the data grid view that the data has changed
                UsersDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Refreshing Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnRefreshUser_Click_1(object sender, EventArgs e)
        {
            DisplayUserData();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            txtUserId.Text = "";
            txtUsername.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            dtpBirthDate.Value = DateTime.Now; // Set to default value or clear it based on your requirement
            txtAge.Text = "";
            cmbGender.SelectedIndex = -1; // Clear the selected gender
            cmbRole.SelectedIndex = -1; // Clear the selected role
            txtSalary.Text = "";
            dtpJoinDate.Value = DateTime.Now; // Set to default value or clear it based on your requirement
            txtNID.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            txtCurrentCity.Text = "";
            cmbBloodGroup.SelectedIndex = -1; // Clear the selected blood group
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (UsersDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = UsersDataGridView.SelectedRows[0];

            // Get the UserId (primary key) value from the selected row
            int userId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string Fname = selectedRow.Cells[3].Value.ToString();
            string Lname = selectedRow.Cells[4].Value.ToString();

            // Execute the delete query or stored procedure to remove the row from the database
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Users WHERE UserId = @UserId", con))
                {
                    command.Parameters.AddWithValue("@UserId", userId);

                    // Open the connection
                    con.Open();

                    // Execute the query
                    command.ExecuteNonQuery();
                    // Remove the selected row from the DataGridView
                    UsersDataGridView.Rows.Remove(selectedRow);
                    MessageBox.Show(Fname + " " + Lname + " - Delete Succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the text box
            string keyword = txtSearch.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM Users WHERE FirstName LIKE @Keyword OR LastName LIKE @Keyword OR CurrentCity LIKE @Keyword OR Gender LIKE @Keyword OR Role LIKE @Keyword OR BloodGroup LIKE @Keyword";

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
                            row["UserId"] = cipher.Decode(row["UserId"].ToString());
                            row["UserName"] = cipher.Decode(row["UserName"].ToString());
                            row["FirstName"] = cipher.Decode(row["FirstName"].ToString());
                            row["LastName"] = cipher.Decode(row["LastName"].ToString());
                            row["Password"] = cipher.Decode(row["Password"].ToString());
                            row["Email"] = cipher.Decode(row["Email"].ToString());
                            row["Birthdate"] = row["Birthdate"].ToString();
                            row["Age"] = cipher.Decode(row["Age"].ToString());
                            row["Gender"] = cipher.Decode(row["Gender"].ToString());
                            row["Role"] = cipher.Decode(row["Role"].ToString());
                            row["Salary"] = cipher.Decode(row["Salary"].ToString());
                            row["JoinDate"] = row["JoinDate"].ToString();
                            row["NID"] = cipher.Decode(row["NID"].ToString());
                            row["Phone"] = cipher.Decode(row["Phone"].ToString());
                            row["Address"] = cipher.Decode(row["Address"].ToString());
                            row["CurrentCity"] = cipher.Decode(row["CurrentCity"].ToString());
                            row["BloodGroup"] = cipher.Decode(row["BloodGroup"].ToString());
                        }
                    }

                    // Bind the DataTable to the DataGridView
                    UsersDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }


        private void PopulateBrandComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Brands table
                string query = "SELECT BrandName FROM Brands";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbBrand.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            // Retrieve the value from the "BrandName" field
                            string brandName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbBrand.Items.Add(brandName);
                        }
                        con.Close();
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void ProductsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ProductsDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = ProductsDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    int productId = Convert.ToInt32(selectedRow.Cells[0].Value);
                    string productName = Convert.ToString(selectedRow.Cells[1].Value);
                    string brandName = selectedRow.Cells[2].Value.ToString();
                    int productQuantity = Convert.ToInt32(selectedRow.Cells[3].Value);
                    int productUnitPrice = Convert.ToInt32(selectedRow.Cells[4].Value);
                    string productStatus = Convert.ToString(selectedRow.Cells[5].Value);
                    int productWeight = Convert.ToInt32(selectedRow.Cells[6].Value);
                    string productDescription = Convert.ToString(selectedRow.Cells[7].Value);
                    // Fetch the brand name based on the BrandId from the Brands table

                    // Populate the input fields
                    txtProductId.Text = productId.ToString();
                    txtProductName.Text = productName;
                    cmbBrand.SelectedItem = brandName; // Assuming you have set up the ComboBox data source with BrandId and BrandName
                    txtQuantity.Text = productQuantity.ToString();
                    txtPerUnitPrice.Text = productUnitPrice.ToString();
                    cmbStatus.SelectedItem = productStatus;
                    txtQuantity.Text = productQuantity.ToString();
                    txtWeight.Text = productWeight.ToString();
                    txtDescription.Text = productDescription;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductId.Text))
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(cmbBrand.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPerUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please Fill Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {

                    // Retrieve the BrandId from the database based on the selected brand name
                    string brandId = "";
                    con.Open();

                    // Execute a query to retrieve the BrandId based on the BrandName
                    string query = "SELECT BrandId FROM Brands WHERE BrandName = '" + cipher.Encode(cmbBrand.SelectedItem.ToString()) + "'";
                    SqlCommand command = new SqlCommand(query, con);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        brandId = Convert.ToString(reader["BrandId"]);
                    }
                    con.Close();
                    reader.Close();

                    string query1 = "exec UpdateProduct '" + Convert.ToInt32(txtProductId.Text) + "','" + cipher.Encode(txtProductName.Text) + "','" + Convert.ToInt32(brandId) + "','" + Convert.ToInt32(txtQuantity.Text) + "','" + Convert.ToInt32(txtPerUnitPrice.Text) + "','" + cipher.Encode(cmbStatus.Text) + "','" + Convert.ToInt32(txtWeight.Text) + "','" + cipher.Encode(txtDescription.Text) + "'";
                    // Open the connection
                    con.Open();
                    command = new SqlCommand(query1, con);

                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Data Updated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Close the connection
                    con.Close();
                }

            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtProductName.Text) ||
                string.IsNullOrWhiteSpace(cmbBrand.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPerUnitPrice.Text) ||
                string.IsNullOrWhiteSpace(cmbStatus.Text) ||
                string.IsNullOrWhiteSpace(txtWeight.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please Fill Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Retrieve the BrandId from the database based on the selected brand name
                string brandId = "";
                con.Open();

                // Execute a query to retrieve the BrandId based on the BrandName
                string query = "SELECT * FROM Brands WHERE BrandName = '" + cipher.Encode(cmbBrand.SelectedItem.ToString()) + "'";
                SqlCommand command = new SqlCommand(query, con);


                SqlDataReader reader;
                reader = command.ExecuteReader();


                if (reader.Read())
                {
                    brandId = Convert.ToString(reader["BrandId"]);
                }
                con.Close();
                reader.Close();


                // Save data to the database
                try
                {
                    con.Open();
                    string query2 = "exec InsertProduct '" + cipher.Encode(txtProductName.Text) + "','" + brandId + "','" + Convert.ToInt32(txtQuantity.Text) + "','" + Convert.ToInt32(txtPerUnitPrice.Text) + "','" + cipher.Encode(cmbStatus.Text) + "','" + Convert.ToInt32(txtWeight.Text) + "','" + cipher.Encode(txtDescription.Text) + "'";
                    command = new SqlCommand(query2, con);
                    command.ExecuteNonQuery();

                    MessageBox.Show("Data Saved Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                 }


            }
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (ProductsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = ProductsDataGridView.SelectedRows[0];

            // Get the UserId (primary key) value from the selected row
            int ProductId = Convert.ToInt32(selectedRow.Cells[0].Value);
            string ProductName = Convert.ToString(selectedRow.Cells[1].Value);

            // Execute the delete query or stored procedure to remove the row from the database
            try
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM Products WHERE ProductId = @ProductId", con))
                {
                    command.Parameters.AddWithValue("@ProductId", ProductId);

                    // Open the connection
                    con.Open();

                    // Execute the query
                    command.ExecuteNonQuery();


                    // Remove the selected row from the DataGridView
                    ProductsDataGridView.Rows.Remove(selectedRow);
                    MessageBox.Show(ProductName + " - Delete Succeeded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void btnCancelProduct_Click(object sender, EventArgs e)
        {
            txtProductId.Text = "";
            txtProductName.Text = "";
            cmbBrand.SelectedIndex = -1;
            txtPerUnitPrice.Text = "";
            cmbStatus.SelectedIndex = -1;
            txtQuantity.Text = "";
            txtWeight.Text = "";
            txtDescription.Text = "";
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword from the text box
            string keyword = guna2TextBox1.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM ProductView WHERE ProductName LIKE @Keyword OR  ProductStatus LIKE @Keyword OR ProductDescription LIKE @Keyword OR BrandName LIKE @Keyword";

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
                            row["ProductId"] = cipher.Decode(row["ProductId"].ToString());
                            row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                            row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                            row["ProductStatus"] = cipher.Decode(row["ProductStatus"].ToString());
                            row["ProductDescription"] = cipher.Decode(row["ProductDescription"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    ProductsDataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the connection
                con.Close();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

        }

        private void CartDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CartDataGridView.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = CartDataGridView.Rows[e.RowIndex];

                    // Extract the data from the row
                    txt_ProductId.Text = selectedRow.Cells[0].Value.ToString();
                    txt_ProductName.Text = Convert.ToString(selectedRow.Cells[1].Value);
                    txtBrandName.Text = Convert.ToString(selectedRow.Cells[4].Value);
                    txtPrice.Text = Convert.ToString(selectedRow.Cells[2].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFillData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ProductId.Text))
            {
                MessageBox.Show("Please Enter Product Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int productid = int.Parse(txt_ProductId.Text);
                string brandid = "";
                try
                {
                    // Create the SQL query
                    con.Open();
                    string query = "SELECT * FROM ProductsView WHERE ProductId ='" + productid + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader read = cmd.ExecuteReader();
                    if (read.Read())
                    {
                        txt_ProductName.Text = cipher.Decode(Convert.ToString(read["ProductName"]));
                        txtPrice.Text = cipher.Decode(Convert.ToString(read["ProductUnitPrice"]));
                        txtBrandName.Text = cipher.Decode(Convert.ToString(read["BrandName"]));

                    }
                    con.Close();
                    read.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while fetching Data: " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            RefreshCart();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_Quantity.Text))
            {
                double price = Convert.ToDouble(txtPrice.Text);
                double quantity = Convert.ToDouble(txt_Quantity.Text);
                double totalAmount = price * quantity;
                txtTotalAmount.Text = Convert.ToString(totalAmount);
            }
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPrice.Text))
                {
                    if (!string.IsNullOrWhiteSpace(txt_Quantity.Text))
                    {
                        double price = Convert.ToDouble(txtPrice.Text);
                        double quantity = Convert.ToDouble(txt_Quantity.Text);
                        double totalAmount = price * quantity;
                        txtTotalAmount.Text = Convert.ToString(totalAmount);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPlaceOrderToSave_Click(object sender, EventArgs e)
        {
            
        }
        private void PopulateUserNameComboBox()
        {
            try
            {
                // Open the database connection
                con.Open();

                // Create a query to retrieve data from the Brands table
                string query = "SELECT FirstName FROM Users";

                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Create a SqlDataReader object to read the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing items from the ComboBox
                        cmbSellBy.Items.Clear();

                        // Loop through the data and add each item to the ComboBox
                        while (reader.Read())
                        {
                            string UserName = cipher.Decode(reader.GetString(0));

                            // Add the value to the ComboBox
                            cmbSellBy.Items.Add(UserName);
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
        private void btnAddMainCate_Click(object sender, EventArgs e)
        {
            Category.formMainCategory MainCategory = new Category.formMainCategory();
            MainCategory.ShowDialog();
        }

        private void btnAddSecondCate_Click(object sender, EventArgs e)
        {
            Category.formSecondCategory SecondCategory = new Category.formSecondCategory();
            SecondCategory.ShowDialog();
        }

        private void btnAddThirdCate_Click(object sender, EventArgs e)
        {
            Category.formThirdCategory ThirdCategory = new Category.formThirdCategory();
            ThirdCategory.ShowDialog();
        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            Category.formVendors Vendors = new Category.formVendors();
            Vendors.ShowDialog();
        }

        private void btnAddBrands_Click(object sender, EventArgs e)
        {
            Category.formBrand Brands = new Category.formBrand();
            Brands.ShowDialog();
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchForSell_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchForSell.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM SalesHistoryView WHERE [Product Name] LIKE @Keyword OR [Payment Method] LIKE @Keyword OR [Employee First Name] LIKE @Keyword OR [Customer Full Name] LIKE @Keyword OR [Customer Email] LIKE @Keyword OR [Customer Address] LIKE @Keyword OR [Customer Phone] LIKE @Keyword";

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
                            row["Order ID"] = cipher.Decode(row["Order ID"].ToString());
                            row["Purchased Date"] = row["Purchased Date"].ToString();
                            row["Product Name"] = cipher.Decode(row["Product Name"].ToString());
                            row["Order Quantity"] = row["Order Quantity"].ToString();
                            row["Total Amount"] = cipher.Decode(row["Total Amount"].ToString());
                            row["Payment Method"] = cipher.Decode(row["Payment Method"].ToString());
                            row["Employee First Name"] = cipher.Decode(row["Employee First Name"].ToString());
                            row["Customer Full Name"] = cipher.Decode(row["Customer Full Name"].ToString());
                            row["Customer Email"] = cipher.Decode(row["Customer Email"].ToString());
                            row["Customer Address"] = cipher.Decode(row["Customer Address"].ToString());
                            row["Customer Phone"] = cipher.Decode(row["Customer Phone"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    SalesHistoryDataGridView.DataSource = dataTable;
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
            int rowCount = SalesHistoryDataGridView.Rows.Count;
            lblTotalSalesHistory.Text = rowCount.ToString();
        }

        private void RefreshSalesHistory()
        {
            // Initialize data adapter and data table
            dataAdapter = new SqlDataAdapter("SELECT * FROM SalesHistoryView ", con);
            dataTable = new DataTable();
            // Fill the data table with data from the database
            dataAdapter.Fill(dataTable);
            // Bind the data table to the data grid view
            SalesHistoryDataGridView.DataSource = dataTable;
            try
            {
                // Clear the data table
                dataTable.Clear();
                // Fill the data table with updated data from the database
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    row["Order ID"] = cipher.Decode(row["Order ID"].ToString());
                    row["Purchased Date"] = row["Purchased Date"].ToString();
                    row["Product Name"] = cipher.Decode(row["Product Name"].ToString());
                    row["Order Quantity"] = row["Order Quantity"].ToString();
                    row["Total Amount"] = cipher.Decode(row["Total Amount"].ToString());
                    row["Payment Method"] = cipher.Decode(row["Payment Method"].ToString());
                    row["Employee First Name"] = cipher.Decode(row["Employee First Name"].ToString());
                    row["Customer Full Name"] = cipher.Decode(row["Customer Full Name"].ToString());
                    row["Customer Email"] = cipher.Decode(row["Customer Email"].ToString());
                    row["Customer Address"] = cipher.Decode(row["Customer Address"].ToString());
                    row["Customer Phone"] = cipher.Decode(row["Customer Phone"].ToString());
                }

                // Notify the data grid view that the data has changed
                SalesHistoryDataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while refreshing data: " + ex.Message);
            }
            int rowCount = SalesHistoryDataGridView.Rows.Count;
            lblTotalSalesHistory.Text = rowCount.ToString();
        }

        private void btnRefreshSalesHistory_Click(object sender, EventArgs e)
        {
            RefreshSalesHistory();
        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProducts.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM ProductsView WHERE ProductName LIKE @Keyword OR BrandName LIKE @Keyword OR ProductStatus LIKE @Keyword";

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
                            row["ProductId"] = cipher.Decode(row["ProductId"].ToString());
                            row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                            row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                            row["ProductStatus"] = cipher.Decode(row["ProductStatus"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    CartDataGridView.DataSource = dataTable;
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
            int rowCount = CartDataGridView.Rows.Count;
            lblTotalProducts.Text = rowCount.ToString();
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            // Print the invoice
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            MessageBox.Show("Invoice Generated Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (MessageBox.Show("Do you want to save the Invoice?", "Confirmation", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (SalesHistoryDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to generate the invoice.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow selectedRow = SalesHistoryDataGridView.SelectedRows[0];

            string orderId = selectedRow.Cells[0].Value.ToString();
            string purchaseDate = selectedRow.Cells[1].Value.ToString();
            string productName = selectedRow.Cells[2].Value.ToString();
            string orderQuantity = selectedRow.Cells[3].Value.ToString();
            string totalAmount = selectedRow.Cells[4].Value.ToString();
            string paymentMethod = selectedRow.Cells[5].Value.ToString();
            string employeeFirstName = selectedRow.Cells[6].Value.ToString();
            string customerFullName = selectedRow.Cells[7].Value.ToString();
            string customerEmail = selectedRow.Cells[8].Value.ToString();
            string customerAddress = selectedRow.Cells[9].Value.ToString();
            string customerPhone = selectedRow.Cells[10].Value.ToString();


            // Define the invoice layout
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font subheaderFont = new Font("Arial", 14, FontStyle.Bold);
            Font normalFont = new Font("Arial", 12);
            float yPos = 100;
            float pageWidth = e.MarginBounds.Width;
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float centre =  (pageWidth - e.Graphics.MeasureString("INVENTORY MANAGEMENT SYSTEM", headerFont).Width) / 2;
            float centre1 = (pageWidth - e.Graphics.MeasureString("INVOICE", headerFont).Width) / 2;
            float centre2 = (pageWidth - e.Graphics.MeasureString("Invoice generated on " + DateTime.Now.ToString(), headerFont).Width) / 2;
            // Draw a dotted line separator
            Pen separatorPen = new Pen(Color.Black, 1);
            separatorPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawLine(separatorPen, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Draw the header
            e.Graphics.DrawString("INVENTORY MANAGEMENT SYSTEM", headerFont, Brushes.Blue, leftMargin + 120, topMargin);
            yPos += headerFont.GetHeight();

            // Draw the invoice title
            e.Graphics.DrawString("INVOICE", subheaderFont, Brushes.Red, leftMargin + 270, yPos);
            yPos += subheaderFont.GetHeight() + 10;

            // Draw a dotted line separator
            e.Graphics.DrawLine(separatorPen, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 10;

            // Print the invoice data
            e.Graphics.DrawString("Order ID: " + orderId.PadRight(50) + "Purchased Date: " + purchaseDate, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 10;

            // Draw a dotted line separator
            e.Graphics.DrawLine(separatorPen, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 40;

            e.Graphics.DrawString("Product Name: " + productName.PadRight(50) + "Order Quantity: " + orderQuantity, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 10;

            e.Graphics.DrawString("Total Amount: " + totalAmount.PadRight(50) + "Payment Method: " + paymentMethod, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 10;

            e.Graphics.DrawString("Seller Name: " + employeeFirstName.PadRight(50) + "Customer Name: " + customerFullName, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 10;

            e.Graphics.DrawString("Customer Email: " + customerEmail.PadRight(50) + "Customer Address: " + customerAddress, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 10;

            e.Graphics.DrawString("Customer Phone: " + customerPhone, normalFont, Brushes.Black, leftMargin, yPos);
            yPos += normalFont.GetHeight() + 40;

            // Draw a dotted line separator
            e.Graphics.DrawLine(separatorPen, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 15;

            // Draw the footer
            e.Graphics.DrawString("Invoice generated on " + DateTime.Now.ToString(), normalFont, Brushes.Red, leftMargin + 130, yPos);
            yPos += normalFont.GetHeight();

            // Draw a dotted line separator
            e.Graphics.DrawLine(separatorPen, leftMargin, yPos, e.MarginBounds.Right, yPos);
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDashboard_MouseHover(object sender, EventArgs e)
        {
            btnDashboard.ImageAlign = HorizontalAlignment.Right;
            btnDashboard.TextAlign = HorizontalAlignment.Left;
        }

        private void btnRefreshMasterCategories_Click(object sender, EventArgs e)
        {
            RefreshMasterCategories();
        }

        private void txtSerachAllCate_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSerachAllCate.Text.Trim();
            try
            {
                // Create the SQL query based on the search keyword
                string query = "SELECT * FROM MasterView WHERE ProductName LIKE @Keyword OR BrandName LIKE @Keyword OR VendorName LIKE @Keyword OR ThirdCategoryName LIKE @Keyword OR SecondCategoryName LIKE @Keyword OR MainCategoryName LIKE @Keyword";

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
                            row["ProductName"] = cipher.Decode(row["ProductName"].ToString());
                            row["BrandName"] = cipher.Decode(row["BrandName"].ToString());
                            row["VendorName"] = cipher.Decode(row["VendorName"].ToString());
                            row["ThirdCategoryName"] = cipher.Decode(row["ThirdCategoryName"].ToString());
                            row["SecondCategoryName"] = cipher.Decode(row["SecondCategoryName"].ToString());
                            row["MainCategoryName"] = cipher.Decode(row["MainCategoryName"].ToString());
                        }

                    }

                    // Bind the DataTable to the DataGridView
                    MasterCategoriesDataGridView.DataSource = dataTable;
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

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            txtSearchProducts.Text = "";
        }

        private void btnViewSalesDetails_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnSellinghistory.Height;
            sideBar.Top = btnSellinghistory.Top;
            MainTabControl.SelectedIndex = 3;
            RefreshSalesHistory();
        }

        private void btnViewStockDetails_Click(object sender, EventArgs e)
        {
            if (lblRole.Text == "Admin" || lblRole.Text == "Cashier")
            {
                sideBar.Height = btnAllstocks.Height;
                sideBar.Top = btnAllstocks.Top;
                MainTabControl.SelectedIndex = 2;
                RefreshProducts();
            }
        }

        private void btnViewUsersDetails_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnMasterusers.Height;
            sideBar.Top = btnMasterusers.Top;
            MainTabControl.SelectedIndex = 1;
        }

        private void btnViewSalariesDetails_Click(object sender, EventArgs e)
        {
            sideBar.Height = btnMasterusers.Height;
            sideBar.Top = btnMasterusers.Top;
            MainTabControl.SelectedIndex = 1;
        }

        private void btnViewMasterCategoriesDetails_Click(object sender, EventArgs e)
        {
            if (lblRole.Text == "Admin")
            {
                sideBar.Height = btnMastercategories.Height;
                sideBar.Top = btnMastercategories.Top;
                MainTabControl.SelectedIndex = 4;
                RefreshMasterCategories();
            }
            
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txt_ProductId.Text = "";
            txt_ProductName.Text = "";
            txtBrandName.Text = "";
            txt_Quantity.Text = "";
            txtPrice.Text = "";
            cmbSellBy.SelectedIndex = -1;
            txtCustomerName.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerPhone.Text = "";
            txtTotalAmount.Clear();
        }

        private void btnPlaceOrderToSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_ProductName.Text) ||
                    string.IsNullOrWhiteSpace(txtPrice.Text) ||
                    string.IsNullOrWhiteSpace(txt_Quantity.Text) ||
                    string.IsNullOrWhiteSpace(cmbSellBy.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtCustomerPhone.Text) ||
                    string.IsNullOrWhiteSpace(cmbPaymentMethod.Text) ||
                    string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Please Input Missing Fields");
                return;
            }
            else
            {
                string UserId = "";
                try
                {
                    con.Open();
                    string query = "Select * from Users Where FirstName = '" + cipher.Encode(cmbSellBy.Text) + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        UserId = Convert.ToString(reader["UserId"]);
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
                    string query = "exec InsertOrder '" + int.Parse(txt_Quantity.Text) + "','" + cipher.Encode(cmbSellBy.Text) + "','" + cipher.Encode(txtCustomerName.Text) + "','" + cipher.Encode(txtCustomerEmail.Text) + "','" + cipher.Encode(txtCustomerAddress.Text) + "','" + cipher.Encode(cmbPaymentMethod.Text) + "','" + cipher.Encode(txtCustomerPhone.Text) + "','" + DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "','" + int.Parse(txtTotalAmount.Text) + "','" + int.Parse(UserId) + "','" + int.Parse(txt_ProductId.Text) + "'";
                    SqlCommand command = new SqlCommand(query, con);
                    // Execute the stored procedure
                    command.ExecuteNonQuery();
                    MessageBox.Show("Order Placed Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message);
                    con.Close();
                }
            }
            con.Close();
            RefreshSalesHistory();
        }

        private void btn_Refresh_Click_1(object sender, EventArgs e)
        {
            RefreshCart();
        }
    }
}


