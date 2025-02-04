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
using YumYard.Customer;
using YumYard.Admin;

//using YumYard.Resowner;
using YumYard.Resowner;



namespace YumYard.Register___Login
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            btnHidePass.Hide();
            lblWarnEmail.Hide();
            lblWarnPass.Hide();
            lblF_pass.Hide();
        }

        private void TextChange(object sender, EventArgs e)
        {
            if (lblWarnEmail.Visible)
            {
                lblWarnEmail.Hide();
            }
            if (lblWarnPass.Visible)
            {
                lblWarnPass.Hide();
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbPass.Text;
            bool hasError = false;

            if (string.IsNullOrWhiteSpace(email))
            {
                lblWarnEmail.Text = "Email is required.";
                lblWarnEmail.Show();
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblWarnPass.Text = "Password is required.";
                lblWarnPass.Show();
                hasError = true;
            }

            if (!hasError)
            {
                try
                {
                    string error;

                    // Check if email and password match in the Admin table
                    string adminQuery = $"SELECT COUNT(*) AS AdminCount FROM Admin WHERE A_Email = '{email}' AND A_Pass = '{password}'";
                    var adminResult = DbAccess.GetData(adminQuery, out error);

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }

                    if (adminResult.Rows.Count > 0 && Convert.ToInt32(adminResult.Rows[0]["AdminCount"]) > 0)
                    {
                        // Admin login successful
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                        return;
                    }

                    // Check if email and password match in the Restaurant table
                    string resQuery = $"SELECT COUNT(*) AS RestaurantCount FROM Restaurant WHERE rEmail = '{email}' AND rPass = '{password}'";
                    var resResult = DbAccess.GetData(resQuery, out error);

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }

                    if (resResult.Rows.Count > 0 && Convert.ToInt32(resResult.Rows[0]["RestaurantCount"]) > 0)
                    {
                        // Restaurant login successful
                        Owner1 owner1 = new Owner1();
                        owner1.Show();
                        this.Hide();
                        return;
                    }

                    // Check if email and password match in the Customer table
                    string customerQuery = $"SELECT COUNT(*) AS UserCount FROM Customer WHERE C_Email = '{email}' AND C_Password = '{password}'";
                    var customerResult = DbAccess.GetData(customerQuery, out error);

                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Oops! Something went wrong: " + error);
                        return;
                    }

                    if (customerResult.Rows.Count > 0 && Convert.ToInt32(customerResult.Rows[0]["UserCount"]) > 0)
                    {
                        string themeQuery = "SELECT TOP 1 tPic FROM RestaurantTheme WHERE tPic IS NOT NULL ORDER BY tID DESC";
                        var themeResult = DbAccess.GetData(themeQuery, out error);

                        byte[] themeImage = null;

                        // ✅ Prevent NULL reference error
                        if (themeResult != null && themeResult.Rows.Count > 0 && themeResult.Rows[0]["tPic"] != DBNull.Value)
                        {
                            themeImage = (byte[])themeResult.Rows[0]["tPic"];
                        }
                        else
                        {
                            MessageBox.Show("No valid theme image found in RestaurantTheme table.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        byte[][] restaurantImages = new byte[4][];  // ✅ This ensures it exists before being used

                        // Fetch 4 images from Restaurant
                        string restaurantQuery = "SELECT TOP 4 ImageData FROM Restaurant ORDER BY (SELECT NULL)";
                        var restaurantResult = DbAccess.GetData(restaurantQuery, out error);

                        // ✅ Ensure restaurantResult is not null before processing
                        if (restaurantResult != null && restaurantResult.Rows.Count > 0)
                        {
                            for (int i = 0; i < restaurantResult.Rows.Count && i < 4; i++)  // ✅ Avoid index out of range
                            {
                                if (restaurantResult.Rows[i]["ImageData"] != DBNull.Value)
                                {
                                    restaurantImages[i] = (byte[])restaurantResult.Rows[i]["ImageData"];
                                }
                                else
                                {
                                    restaurantImages[i] = null; // Handle case where image is missing
                                }
                            }
                        }

                        // Pass images to ResturantPicker
                        ResturantPicker resturantPicker = new ResturantPicker(email, themeImage, restaurantImages);
                        resturantPicker.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password.");
                        lblF_pass.Show();
                        lblWarnEmail.Hide();
                        lblWarnPass.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to sign in: " + ex.Message);
                }
            }
        }


        // Go into registration form
        private void btnClickHere_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            btnShowPass.Hide();
            btnHidePass.Show();
            tbPass.PasswordChar = '\0';
            tbPass.Focus();
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            btnHidePass.Hide();
            btnShowPass.Show();
            tbPass.PasswordChar = '*';
            tbPass.Focus();
        }

        private void lblF_pass_Click(object sender, EventArgs e)
        {
            PassForgot passForgot = new PassForgot();
            passForgot.Show();
            this.Hide();
            //MessageBox.Show("Will got to Forget pass freature");
        }
    }
}