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

namespace BioMarktUebung
{
    public partial class billScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Wolvy\OneDrive\Dokumente\Pro-Natur Biomarkt Übung.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedProductKey;

        public billScreen()
        {
            InitializeComponent();
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBoxName.Text == ""
                || txtBoxID.Text == ""
                || txtBoxAdress.Text == ""
                || txtBoxAdress.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte/Felder aus.");
                return;
            }

            string customerId    = txtBoxID.Text;
            string customerName = txtBoxAdress.Text;
            string customerAdress = txtBoxAdress.Text;
            string customerPrice = txtBoxTotalPrice.Text;

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", customerId, customerName, customerAdress, customerPrice);

            //ExecuteQuery(query);
            //ClearAllFields();
            //ShowProducts();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxName.Text = "";
            txtBoxID.Text = "";
            txtBoxAdress.Text = "";
            txtBoxTotalPrice.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
