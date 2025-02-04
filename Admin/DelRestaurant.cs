using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using YumYard.DatabaseAccess;
using static YumYard.Admin.Dashboard;

namespace YumYard.Admin
{
    public partial class DelRestaurant : Form
    {
        private RestaurantManagement restaurantManagement;

        public DelRestaurant(RestaurantManagement managementForm)
        {
            InitializeComponent();
            restaurantManagement = managementForm;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string emailToDelete = txtEmail.Text.Trim();
            if (string.IsNullOrEmpty(emailToDelete))
            {
                MessageBox.Show("Please enter an email to delete.");
                return;
            }

            string query = "DELETE FROM Restaurant WHERE rEmail = @email";
            string error;

            // ✅ Use ExecuteNonQuery instead of ExecuteQuery (fixes error)
            bool success = DbAccess.ExecuteNonQuery(query, new Dictionary<string, object>
            {
                { "@email", emailToDelete }
            }, out error);

            if (success)
            {
                MessageBox.Show("Restaurant deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // ✅ Refresh DataGridView in RestaurantManagement
                restaurantManagement.LoadRestaurantData();

                this.Close(); // ✅ Close the delete form
            }
            else
            {
                MessageBox.Show("Error deleting restaurant: " + error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void A_B_Dashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // ✅ Close before navigating
            NavigationHelper.OpenDashboard(this);
        }

        private void A_B_UserInfo_Click(object sender, EventArgs e)
        {
            this.Close(); // ✅ Close before navigating
            NavigationHelper.OpenUserInfo(this);
        }

        private void A_B_RestaurantManagement_Click(object sender, EventArgs e)
        {
            this.Close(); // ✅ Close before navigating
            NavigationHelper.OpenRestaurantManagement(this);
        }

        private void A_B_Theme_Click(object sender, EventArgs e)
        {
            this.Close(); // ✅ Close before navigating
            NavigationHelper.OpenTheme(this);
        }

        private void A_B_Logout_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenLogout(this);
        }
    }
}
