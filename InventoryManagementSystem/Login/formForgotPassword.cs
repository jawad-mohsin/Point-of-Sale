using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Login
{
    public partial class formForgotPassword : Form
    {
        Cipher cipher = new Cipher();

        public formForgotPassword()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool CheckIfEmailExists(string email)
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=JAWAD\SQLEXPRESS;Initial Catalog=inventoryDB;Integrated Security=True"))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@Email", email);
                con.Open();
                int count = (int)command.ExecuteScalar();
                con.Close();
                return count > 0;
            }
        }

        private string GenerateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void SendOTP(string email, string otp)
        {
            string mail = "imsemailverify@gmail.com";
            string pass = "qdcwxalwhoxohkdk";
            try
            {
                // Configure SMTP settings for sending emails
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new System.Net.NetworkCredential(mail, pass);
                smtpClient.EnableSsl = true;


                //MailMessage mm = new MailMessage();
                //mm.From = new MailAddress(mail);
                //mm.To.Add(email);
                //mm.Subject = "Test";
                //mm.Body = "Jawad Mohsin";

                //smtpClient.Send(mm);
                //// Create the email message
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(mail);
                mailMessage.To.Add(email);
                mailMessage.Subject = "Password Recovery OTP";
                mailMessage.Body = $"Dear User,\n\nWe have received a request to reset your password. Please use the following One-Time Password (OTP) to proceed with the password reset:\n\nOTP: {otp}\n\nPlease enter this OTP to complete the password reset process.\n\nIf you did not initiate this password reset request, please ignore this email and ensure the security of your account.\n\nIf you have any questions or need further assistance, please contact our support team.\n\nThank you,\nThe IMS Team";

                //// Send the email
                smtpClient.Send(mailMessage);
                MessageBox.Show("Email Sent Sucessfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please Enter a Valid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please Enter a Valid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the email address exists in the database
            bool emailExists = CheckIfEmailExists(cipher.Encode(email));

            if (emailExists)
            {
                string otp = GenerateOTP();
                SendOTP(email, otp);
                this.Hide();
                this.Close();
                formResetPassword rp = new formResetPassword(cipher.Encode(email),otp);
                rp.ShowDialog();
            }
            else
            {
                MessageBox.Show("Provided Email Address Doesn't Exist in IMS Database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if ((IsValidEmail(txtEmail.Text)) && (CheckIfEmailExists(cipher.Encode(txtEmail.Text))))
            {
                txtEmail.BorderColor = Color.Green;
                btnSendOTP.Focus();
            }
            else
            {
                txtEmail.BorderColor = Color.Red;
            }
        }
    }
}
