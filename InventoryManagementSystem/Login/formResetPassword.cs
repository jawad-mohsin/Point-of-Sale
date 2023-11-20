using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Login
{
    public partial class formResetPassword : Form
    {
        Cipher cipher = new Cipher();
        string otp;
        public formResetPassword(string email, string otp)
        {
            InitializeComponent();
            txtDigit1.Focus();
            lblEmail.Text = cipher.Decode(email);
            this.otp = otp;
            
        }

        private void txtDigit1_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit1.TextLength == txtDigit1.MaxLength)
            {
                txtDigit2.Focus();
            }
        }

        private void txtDigit2_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit2.TextLength == txtDigit2.MaxLength)
            {
                txtDigit3.Focus();
            }
        }

        private void txtDigit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                txtDigit2.Clear();
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                if (txtDigit2.TextLength != txtDigit2.MaxLength)
                {
                    txtDigit1.Focus();
                    txtDigit1.Text = "";
                }
                else
                {
                    txtDigit2.Clear();
                }
            }
        }

        private void txtDigit3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                txtDigit3.Clear();
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                if (txtDigit3.TextLength != txtDigit3.MaxLength)
                {
                    txtDigit2.Focus();
                    txtDigit2.Text = "";
                }
                else
                {
                    txtDigit3.Clear();
                }
            }
        }

        private void txtDigit4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                txtDigit4.Clear();
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                if (txtDigit4.TextLength != txtDigit4.MaxLength)
                {
                    txtDigit3.Focus();
                    txtDigit3.Text = "";
                }
                else
                {
                    txtDigit4.Clear();
                }
            }
        }

        private void txtDigit5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                txtDigit5.Clear();
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                if (txtDigit5.TextLength != txtDigit5.MaxLength)
                {
                    txtDigit4.Focus();
                    txtDigit4.Text = "";
                }
                else
                {
                    txtDigit5.Clear();
                }
            }
        }

        private void txtDigit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                if (txtDigit6.TextLength != txtDigit6.MaxLength)
                {
                    txtDigit6.Clear();
                }
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                if (txtDigit6.TextLength != txtDigit6.MaxLength)
                {
                    txtDigit5.Focus();
                    txtDigit5.Text = "";
                }
                else
                {
                    txtDigit6.Clear();
                }
            }
        }

        private void txtDigit3_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit3.TextLength == txtDigit3.MaxLength)
            {
                txtDigit4.Focus();
            }
        }

        private void txtDigit4_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit4.TextLength == txtDigit4.MaxLength)
            {
                txtDigit5.Focus();
            }
        }

        private void txtDigit5_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit5.TextLength == txtDigit5.MaxLength)
            {
                txtDigit6.Focus();
            }
        }

        private void txtDigit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancel the input if it is not a digit or the backspace key
                txtDigit1.Clear();
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if((otp[0].ToString() == txtDigit1.Text ) &&
                (otp[1].ToString() == txtDigit2.Text) &&
                (otp[2].ToString() == txtDigit3.Text) &&
                (otp[3].ToString() == txtDigit4.Text) &&
                (otp[4].ToString() == txtDigit5.Text) &&
                (otp[5].ToString() == txtDigit6.Text))
            {
                this.Hide();
                this.Close();
                formChangePassword cp = new formChangePassword(lblEmail.Text);
                cp.ShowDialog();
            }
        }

        private void txtDigit6_TextChanged(object sender, EventArgs e)
        {
            if (txtDigit6.TextLength == txtDigit6.MaxLength)
            {
                btnVerify.Focus();
                if ((otp[0].ToString() == txtDigit1.Text) &&
                (otp[1].ToString() == txtDigit2.Text) &&
                (otp[2].ToString() == txtDigit3.Text) &&
                (otp[3].ToString() == txtDigit4.Text) &&
                (otp[4].ToString() == txtDigit5.Text) &&
                (otp[5].ToString() == txtDigit6.Text))
                {
                    txtDigit1.BorderColor = Color.DarkGreen;
                    txtDigit2.BorderColor = Color.DarkGreen;
                    txtDigit3.BorderColor = Color.DarkGreen;
                    txtDigit4.BorderColor = Color.DarkGreen;
                    txtDigit5.BorderColor = Color.DarkGreen;
                    txtDigit6.BorderColor = Color.DarkGreen;
                }
                else
                {
                    txtDigit1.BorderColor = Color.Red;
                    txtDigit2.BorderColor = Color.Red;
                    txtDigit3.BorderColor = Color.Red;
                    txtDigit4.BorderColor = Color.Red;
                    txtDigit5.BorderColor = Color.Red;
                    txtDigit6.BorderColor = Color.Red;
                }
            }
            else
            {
                txtDigit1.BorderColor = Color.FromArgb(115, 55, 238);
                txtDigit2.BorderColor = Color.FromArgb(115, 55, 238);
                txtDigit3.BorderColor = Color.FromArgb(115, 55, 238);
                txtDigit4.BorderColor = Color.FromArgb(115, 55, 238);
                txtDigit5.BorderColor = Color.FromArgb(115, 55, 238);
                txtDigit6.BorderColor = Color.FromArgb(115, 55, 238);
            }
        }
    }
}
