using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using YumYard.DatabaseAccess;
using YumYard.Admin;
using YumYard.Resowner;
using static YumYard.Admin.Dashboard;

namespace YumYard.Admin
{
    public partial class Add_Restaurant : Form
    {
        private string imagePath = ""; // Store image path

        public Add_Restaurant()
        {
            InitializeComponent();
            LoadDefaultImage();
        }





        private void LoadDefaultImage()
        {
            pic.Image = Properties.Resources.chefhead_ICON; // Use a default image
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }





        public void btn_Upload_Click_1(object sender, EventArgs e)
        {
            try
            {
                // ✅ Validate input fields before saving
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtDescription.Text))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                if (!File.Exists(imagePath))
                {
                    MessageBox.Show("Please select an image.");
                    return;
                }

                // ✅ Convert selected image to byte array
                byte[] imageBytes = File.ReadAllBytes(imagePath);

                // ✅ Use correct INSERT query (RO_ID auto-increments)
                string query = "INSERT INTO Restaurant (rName, rEmail, rPass, ImageData , rDetails) " +
                               "VALUES (@Name, @Email, @Password, @Image, @Description)";

                using (SqlConnection conn = new SqlConnection(DbAccess.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Image", imageBytes);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);

                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }

                MessageBox.Show("✅ Restaurant added successfully!");

                // ✅ Refresh DataGridView in RestaurantManagement.cs
                if (this.Owner is RestaurantManagement restaurantForm)
                {
                    restaurantForm.LoadRestaurantData(); // Call method to refresh DataGridView
                }
                RestaurantManagement RM = new RestaurantManagement();
                RM.Show();
                this.Close(); // ✅ Close the form after adding data
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("❌ Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error saving data: " + ex.Message);
            }
        }



        private void btn_SelectImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select an Image",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                pic.Image = Image.FromFile(imagePath);
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
