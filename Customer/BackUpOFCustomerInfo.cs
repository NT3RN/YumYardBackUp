using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.Customer.Forms;
using YumYard.DatabaseAccess;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace YumYard.Customer
{
    public partial class BackUpOFCustomerInfo : Form
    {
        private string email;
        
        public BackUpOFCustomerInfo(string Email)
        {
            InitializeComponent();
            this.email = Email;
            lblTitle.Text = "User Information";
            ActiveButton(btnUser);

            LoadForm(new UserInfoBackup(email));
        }

        private void LoadForm(Form form)
        {
            if (this.panelCustomerDisplay.Controls.Count > 0)
                this.panelCustomerDisplay.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.panelCustomerDisplay.Controls.Add(form);
            this.panelCustomerDisplay.Tag = form;
            form.Show();
        }

        private void NonActiveButton(Button nonActiveButton)
        {
            nonActiveButton.BackColor = Color.FromArgb(35, 31, 20);
        }

        private void ActiveButton(Button activeButton)
        {
            activeButton.BackColor = Color.LightBlue;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Home";
            ActiveButton(btnHome);

            string error;

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
            ResturantPicker resturantPicker = new ResturantPicker(email);
            resturantPicker.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "User Information";
            ActiveButton(btnUser);
            NonActiveButton(btnOrderInfo);
            NonActiveButton(btnHome);
            LoadForm(new UserInfoBackup(email));
        }

        private void btnOrderInfo_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "My Orders";
            ActiveButton(btnOrderInfo);
            NonActiveButton(btnUser);
            NonActiveButton(btnHome);
            LoadForm(new CustomerOderDetails(email));

        }
    }
}
