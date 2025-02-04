using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YumYard.Customer;
using YumYard.Register___Login;

namespace YumYard
{
    public partial class YumYard : Form
    {
        public YumYard()
        {
            InitializeComponent();
        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void YumYard_Load(object sender, EventArgs e)
        {

        }
    }
}
