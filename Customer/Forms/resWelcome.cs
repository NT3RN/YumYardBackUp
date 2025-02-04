using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YumYard.Customer.Forms
{
    public partial class resWelcome : Form
    {
        private string resName;
        public resWelcome(string rName)
        {
            InitializeComponent();
            resName = rName;
            tbWelcome.Text = $"Welcome to {resName}! \nSelect Order section to get started";

        }
    }
}
