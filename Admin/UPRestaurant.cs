using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.DatabaseAccess;
using static YumYard.Admin.Dashboard;

namespace YumYard.Admin
{
    public partial class UPRestaurant : Form
    {
        public UPRestaurant()
        {
            InitializeComponent();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text.Trim();
                string name = txtName.Text.Trim();
                string password = txtPassword.Text.Trim();
                string description = txtDescription.Text.Trim();

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter an email to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Check if email exists
                string checkQuery = "SELECT COUNT(*) FROM Restaurant WHERE rEmail = @Email";
                string error;
                DataTable result = DbAccess.GetData(checkQuery.Replace("@Email", $"'{email}'"), out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Database error: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (result.Rows.Count > 0 && Convert.ToInt32(result.Rows[0][0]) > 0)
                {
                    // ✅ Convert Image to Byte Array
                    byte[] imageData = null;
                    if (pic6.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            pic6.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageData = ms.ToArray();
                        }
                    }

                    // ✅ Define Query & Parameters
                    string updateQuery;
                    Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@Name", name },
                { "@Password", password },
                { "@Description", description },
                { "@Email", email }
            };

                    if (imageData != null)
                    {
                        updateQuery = "UPDATE Restaurant SET rName = @Name, rPass = @Password, rDetails = @Description, ImageData = @ImageData WHERE rEmail = @Email";
                        parameters.Add("@ImageData", imageData);
                    }
                    else
                    {
                        updateQuery = "UPDATE Restaurant SET rName = @Name, rPass = @Password, rDetails = @Description WHERE rEmail = @Email";
                    }

                    // ✅ Execute Query
                    bool success = DbAccess.ExecuteNonQuery(updateQuery, parameters, out error);

                    if (success)
                    {
                        MessageBox.Show("Restaurant details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // ✅ Close this form and refresh RestaurantManagement
                        this.Hide();
                        RestaurantManagement restaurantManagement = new RestaurantManagement();
                        restaurantManagement.Show();
                        restaurantManagement.LoadRestaurantData(); // Refresh GridView
                    }
                    else
                    {
                        MessageBox.Show("Update failed: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email not found. No update performed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btn_SelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic6.Image = Image.FromFile(openFileDialog.FileName); // Show selected image in PictureBox
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenDashboard(this);
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenUserInfo(this);
        }

        private void btnRestaurantManagement_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenRestaurantManagement(this);
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenTheme(this);
        }

        private void A_B_Logout_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenLogout(this);
        }
    }
}


