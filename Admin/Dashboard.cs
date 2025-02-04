using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.Register___Login;
using static YumYard.Admin.UserInfo;

namespace YumYard.Admin
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public static class NavigationHelper
        {
            public static void OpenDashboard(Form currentForm)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                currentForm.Hide();
            }

            public static void OpenUserInfo(Form currentForm)
            {

                UserInfo userInfo = new UserInfo();
                userInfo.Show();
                userInfo.LoadUserDataPublic();
                currentForm.Hide();

            }


            public static void OpenOrderHistory(Form currentForm)
            {
                
            }


            public static void OpenRestaurantManagement(Form currentForm)
            {
                RestaurantManagement restaurantManagement = new RestaurantManagement();
                restaurantManagement.Show();
                currentForm.Hide();
            }

            public static void OpenTheme(Form currentForm)
            {
                Theme theme = new Theme();
                theme.Show();
                currentForm.Hide();
            }



            public static void OpenVoucher(Form currentForm)
            {
                
            }
            public static void OpenLogout(Form currentForm)
            {
                var confirmResult = MessageBox.Show("Are you sure you want to logout?", "Confirm logout", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    LogIn logIn = new LogIn();
                    logIn.Show();
                    currentForm.Hide();
                }
            }

            

        }




        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenLogout(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenUserInfo(this);
        }

        private void A_B_OrderHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void A_B_RestaurantManagement_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenRestaurantManagement(this);
        }

        private void A_B_Theme_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenTheme(this);
        }

        private void A_B_Voucher_Click(object sender, EventArgs e)
        {
            
        }
    }
}
