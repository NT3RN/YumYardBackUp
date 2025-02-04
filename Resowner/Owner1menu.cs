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

namespace YumYard.Resowner
{
    public partial class Owner1menu : Form
    {
        public Owner1menu()
        {
            InitializeComponent();
            LoadProductData();

        }


        private void LoadProductData()
        {
            try
            {
                string query = "SELECT ProductID, ProductName, ProductPrice,RestaurantID FROM RestaurantProducts";
                string error;
                DataTable dt = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Error loading product data: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvProducts.DataSource = dt;
                dgvProducts.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnmenuadd_Click(object sender, EventArgs e)
        {

            //Owner1add owner1Menuadd = new Owner1add();
            //owner1Menuadd.Show();
            //this.Hide();


        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Owner1 owner1 = new Owner1();
            owner1.Show();
            this.Hide();
        }
    }
}