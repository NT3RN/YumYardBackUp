using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class RestaurantManagement : Form
    {


        public RestaurantManagement()
        {
            InitializeComponent();
            LoadRestaurantData();
        }
        public void LoadRestaurantData()
        {
            try
            {
                string query = "SELECT rName, rEmail, rPass, ImageData, rDetails FROM Restaurant"; 
                string error;
                DataTable dt = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error loading data: " + error);
                    return;
                }

                // ✅ Convert Binary Image Data to Image Format
                DataTable dtWithImages = new DataTable();
                dtWithImages.Columns.Add("rName", typeof(string));
                dtWithImages.Columns.Add("rEmail", typeof(string));
                dtWithImages.Columns.Add("rPass", typeof(string));
                dtWithImages.Columns.Add("rDetails", typeof(string));
                dtWithImages.Columns.Add("ImageData", typeof(Image)); 


                foreach (DataRow row in dt.Rows)
                {
                    byte[] imgData = row["ImageData"] as byte[]; // ✅ Get image data
                    Image image = null;

                    if (imgData != null && imgData.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            image = Image.FromStream(ms); // ✅ Convert to Image
                        }
                    }

                    dtWithImages.Rows.Add(
                        row["rName"],
                        row["rEmail"],
                        row["rPass"],
                        row["rDetails"],
                        image
                    );
                }

                // ✅ Bind to DataGridView
                dataGridView1.DataSource = dtWithImages;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // ✅ Set Image Column Display
                if (!dataGridView1.Columns.Contains("ImageData"))
                {
                    DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                    imageColumn.Name = "ImageData";
                    imageColumn.HeaderText = "Restaurant Image";
                    imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // ✅ Adjust image layout
                    dataGridView1.Columns.Add(imageColumn);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        public void btn_New_Click(object sender, EventArgs e)
        {
            Add_Restaurant AR = new Add_Restaurant();
            AR.Show();
            this.Hide();
        }

        private void RestaurantManagement_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void A_B_Dashboard_Click(object sender, EventArgs e)
        {
            Dashboard.NavigationHelper.OpenDashboard(this);
        }

        private void A_B_UserInfo_Click(object sender, EventArgs e)
        {
            Dashboard.NavigationHelper.OpenUserInfo(this);
        }

        private void A_B_OrderHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void A_B_RestaurantManagement_Click(object sender, EventArgs e)
        {
            Dashboard.NavigationHelper.OpenRestaurantManagement(this);
        }

        private void A_B_Theme_Click(object sender, EventArgs e)
        {
            Dashboard.NavigationHelper.OpenTheme(this);
        }

        private void A_B_Voucher_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UPRestaurant UPR = new UPRestaurant();
            UPR.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DelRestaurant deleteForm = new DelRestaurant(this); // Pass reference to current form
            this.Hide(); // Hide the current form
            deleteForm.ShowDialog(); // Open the delete form as a modal dialog
            this.Show();

        }

        private void A_B_Logout_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenLogout(this);
        }
    }
}
