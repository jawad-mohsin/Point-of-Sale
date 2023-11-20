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

namespace InventoryManagementSystem.Login
{
    public partial class Login : Form
    {
        Cipher cipher = new Cipher();
        public static string role = "";
        SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        private string Username()
        {
            string username = "";
            con.Open();
            string query = "Select * from Users where UserName = '"+cipher.Encode(txtusername.Text)+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                username = (dr["FirstName"] +" "+ dr["LastName"]);
            }
            return cipher.Decode(username);
            dr.Close();
            con.Close();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                role = cmbRole.SelectedItem.ToString();
                if (role == "Admin")
                {
                    cm = new SqlCommand("EXEC GetAdminCredentials @Username, @Password;",con);
                    cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                    cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.Close();
                        formDashboard db = new formDashboard(Username(),role);
                        this.Hide();
                        db.ShowDialog();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (role == "Cashier")
                {
                    cm = new SqlCommand("EXEC GetCashierCredentials @Username, @Password;", con);
                    cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                    cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.Close();
                        formDashboard db = new formDashboard(Username(),role);
                        this.Hide();
                        db.ShowDialog();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (role == "Salesman")
                {
                    cm = new SqlCommand("EXEC GetSalesmanCredentials @Username, @Password;", con);
                    cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                    cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                    con.Open();
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        con.Close();
                        formDashboard db = new formDashboard(Username(),role);
                        this.Hide();
                        db.ShowDialog();
                    }
                    else
                    {
                        con.Close();
                        MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Valid Role..!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                try
                {
                    role = cmbRole.SelectedItem.ToString();
                    if (role == "Admin")
                    {
                        cm = new SqlCommand("EXEC GetAdminCredentials @Username, @Password;", con);
                        cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                        cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                        con.Open();
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            con.Close();
                            formDashboard db = new formDashboard(Username(),role);
                            this.Hide();
                            db.ShowDialog();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (role == "Cashier")
                    {
                        cm = new SqlCommand("EXEC GetCashierCredentials @Username, @Password;", con);
                        cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                        cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                        con.Open();
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            con.Close();
                            formDashboard db = new formDashboard(Username(), role);
                            this.Hide();
                            db.ShowDialog();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (role == "Salesman")
                    {
                        cm = new SqlCommand("EXEC GetSalesmanCredentials @Username, @Password;", con);
                        cm.Parameters.AddWithValue("@Username", cipher.Encode(txtusername.Text));
                        cm.Parameters.AddWithValue("@Password", cipher.Encode(txtPassword.Text));
                        con.Open();
                        dr = cm.ExecuteReader();
                        dr.Read();
                        if (dr.HasRows)
                        {
                            con.Close();
                            formDashboard db = new formDashboard(Username(), role);
                            this.Hide();
                            db.ShowDialog();
                        }
                        else
                        {
                            con.Close();
                            MessageBox.Show("Invalid Username or Password..!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select a Valid Role..!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            formForgotPassword fg = new formForgotPassword();
            fg.ShowDialog();
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar.ToString() == "•")
            {
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Image = Properties.Resources.show;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                btnShowPassword.Image = Properties.Resources.hide;
            }
        }
    }
}
