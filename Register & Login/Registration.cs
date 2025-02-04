using System;
using System.Collections;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();

            lblWarnUN.Hide();
            lblWarnEmail.Hide();
            lblWarnPass.Hide();
            lblWarnConPass.Hide();
            lblGender.Hide();
            btnHidePass.Hide();  
            lblLogin.Show();
            btnLogin.Show();
        }

        private void passMatch(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbConPass.Text))
            {
                lblWarnConPass.Hide();
            }
            else if (tbPassword.Text != tbConPass.Text)
            {
                lblWarnConPass.Text = "Passwords do not match.";
                lblWarnConPass.Show();
            }
            else
            {
                lblWarnConPass.Hide();
            }
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Hide();
            btnHidePass.Show();
            tbPassword.PasswordChar = '\0';
            tbConPass.PasswordChar = '\0';
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnHidePass.Hide();
            btnShowPass.Show();
            tbPassword.PasswordChar = '*';
            tbConPass.PasswordChar = '*';
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConPass.Text;
            string email = tbEmail.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                lblWarnUN.Text = "Username is required.";
                lblWarnUN.Show();
                lblWarnEmail.Hide();
                lblWarnPass.Hide();
                lblWarnConPass.Hide();
                lblGender.Hide();
                return;
            }
            else
            {
                lblWarnUN.Hide();
            }

            if (string.IsNullOrWhiteSpace(email) || !Validation.IsValidEmail(email))
            {
                lblWarnEmail.Text = "Valid email is required.";
                lblWarnEmail.Show();
                lblWarnPass.Hide();
                lblWarnConPass.Hide();
                lblGender.Hide();
                return;
            }
            else
            {
                lblWarnEmail.Hide();
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblWarnPass.Text = "Password is required.";
                lblWarnPass.Show();
                lblWarnConPass.Hide();
                lblGender.Hide();
                return;
            }
            else if (!Validation.IsValidPassword(password))
            {
                lblWarnPass.Text = "At least 8 characters, contains letters, special character & numbers.";
                lblWarnPass.Show();
                lblWarnConPass.Hide();
                return;
            }
            else
            {
                lblWarnPass.Hide();
            }

            if (string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblWarnConPass.Text = "Confirm Password is required.";
                lblWarnConPass.Show();
                lblGender.Hide();
                return;
            }
            else if (password != confirmPassword)
            {
                lblWarnConPass.Text = "Passwords do not match.";
                lblWarnConPass.Show();
                return;
            }
            else
            {
                lblWarnConPass.Hide();
            }

            string gender = "";
            if (rbtnMale.Checked)
            {
                gender = "Male";
            }
            else if (rbtnFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                lblGender.Text = "Please select gender";
                lblGender.Show();
                return;
            }

            try
            {
                // Check if email already exists in the database
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
                    lblWarnEmail.Text = "Email already exists.";
                    lblWarnEmail.Show();
                    tbEmail.Focus();
                    return;
                }

                // Inserting customer data into database
                string RegQuery = $"INSERT INTO Customer (C_Name,C_Password,C_Email,C_Gender) values ('{username}','{password}','{email}','{gender}') ";
                DbAccess.ExecuteQuery(RegQuery, out error);
                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show(error);
                    return;
                }
                MessageBox.Show("Registration Successful.");
                tbName.Clear();
                tbEmail.Clear();
                tbPassword.Clear();
                tbConPass.Clear();
                rbtnMale.Checked = false;
                rbtnFemale.Checked = false;
                lblWarnUN.Hide();
                lblWarnEmail.Hide();
                lblWarnPass.Hide();
                lblWarnConPass.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to register: " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();
        }
    }
}
