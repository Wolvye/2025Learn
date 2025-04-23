using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioMarktUebung
{
    public partial class MainMenuScreen : Form
    {
        public MainMenuScreen()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductScreen productScreen = new ProductScreen();
            productScreen.Show();
            this.Hide();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
           billScreen billScreen = new billScreen();
            billScreen.Show(); 
            this.Hide();
        }
    }
}
