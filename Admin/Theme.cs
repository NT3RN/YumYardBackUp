using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YumYard.DatabaseAccess;
using static YumYard.Admin.Dashboard;

namespace YumYard.Admin
{
    public partial class Theme : Form
    {
        private string selectedImagePath = "";

        public Theme()
        {
            InitializeComponent();
        }

        // ✅ Step 1: Browse and Select Image
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select a Background Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                picTheme.Image = Image.FromFile(selectedImagePath);
                lblThemeC.Visible = false;
            }
        }

        // ✅ Step 2: Save Image and Auto-Increment Theme ID
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (picTheme.Image == null)
                {
                    MessageBox.Show("Please select an image before updating.");
                    return;
                }

                // Convert image to byte array
                byte[] imageBytes = ImageToByteArray(picTheme.Image);

                using (SqlConnection conn = new SqlConnection(DbAccess.ConnectionString))
                {
                    conn.Open();

                    // ✅ Insert only the image (tID auto-increments)
                    string query = "INSERT INTO RestaurantTheme (tPic) OUTPUT INSERTED.tID VALUES (@Image)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Image", imageBytes);

                        // ✅ Get the new tID
                        int newThemeID = (int)cmd.ExecuteScalar();
                        MessageBox.Show($"✅ Theme image saved successfully with ID: {newThemeID}");
                    }
                }

                
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("❌ Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error saving data: " + ex.Message);
            }
            NavigationHelper.OpenDashboard(this);
        }


        // ✅ Convert Image to Byte Array
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save as PNG format
                return ms.ToArray();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenLogout(this);
        }
    }
}
