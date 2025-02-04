using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace YumYard.Resowner
{
    public partial class Owner1 : Form
    {

        public Owner1()
        {
            InitializeComponent();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Owner1menu owner1Menu = new Owner1menu();
            owner1Menu.Show();
            this.Hide();
        }
    }
}