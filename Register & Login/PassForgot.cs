using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.DatabaseAccess;

namespace YumYard.Register___Login
{
    public partial class PassForgot : Form
    {
        string email;
        public PassForgot()
        {
            InitializeComponent();
            lblWnEmail.Visible = false;
        }
        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            lblWnEmail.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            email = tbEmail.Text;

            
            
            if (!Validation.IsValidEmail(email))
            {
                if (string.IsNullOrEmpty(email))
                {
                    lblWnEmail.Text = "Email is required.";
                    lblWnEmail.Visible = true;
                }
                else
                {
                    lblWnEmail.Text = "Invalid email address.";
                    lblWnEmail.Visible = true;
                }
            }
            else
            {
                try
                {
                    // Check if the updated email already exists in the database
                    string checkEmailQuery = $"SELECT COUNT(*) AS EmailCount FROM Customer WHERE C_Email = '{email}'";
                    string error;
                    var emailCheckResult = DbAccess.GetData(checkEmailQuery, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }

                    if (emailCheckResult.Rows.Count > 0 && Convert.ToInt32(emailCheckResult.Rows[0]["EmailCount"]) > 0)
                    {
                        tbEmail.Clear();
                        MessageBox.Show("Password reset link sent to your email.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong:"+ex.Message);
                }


            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            this.Hide();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
