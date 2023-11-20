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
    public partial class formChangePassword : Form
    {
        Cipher cipher = new Cipher();
        string email;
        public formChangePassword(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True"))
                    {
                        con.Open();
                        string query = "UPDATE Users SET Password = '" + cipher.Encode(txtPassword1.Text) + "' WHERE Email = @Email";
                        SqlCommand command = new SqlCommand(query, con);
                        command.Parameters.AddWithValue("@Email", cipher.Encode(email));
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Password Changed Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    this.Close();
                    Login login = new Login();
                    login.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password Doesn't Match, Please Try Again ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword1.Text == txtPassword2.Text)
            {
                txtPassword1.BorderColor = Color.DarkGreen;
                txtPassword2.BorderColor = Color.DarkGreen;
                btnChangePassword.Focus();
            }
            else
            {
                txtPassword2.BorderColor = Color.Red;
            }
        }
    }
}
