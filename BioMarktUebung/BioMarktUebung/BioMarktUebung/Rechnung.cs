using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
            ShowCustomers();
        }

        private void Rechnung_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this._Pro_Natur_Biomarkt_ÜbungDataSet1.Customers);

        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtBoxName.Text == ""
                //|| txtBoxID.Text == ""
                || txtBoxAdress.Text == ""
                || txtBoxAdress.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte/Felder aus.");
                return;
            }

            //string customerId    = txtBoxID.Text;
            string customerName = txtBoxName.Text;
            string customerAdress = txtBoxAdress.Text;
            string customerPrice = txtBoxTotalPrice.Text;

            string query = string.Format("insert into Customers values('{0}','{1}')", customerName, customerAdress);

            ExecuteQuery(query);
            ClearAllFields();
            ShowCustomers();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
            }

           // string customerId = txtBoxID.Text;
            string customerName = txtBoxAdress.Text;
            string customerAdress = txtBoxAdress.Text;
            string customerPrice = txtBoxTotalPrice.Text;

            string query = string.Format("insert into Customers values('{0}','{1}','{2}',)"
                , customerName, customerAdress, customerPrice);
            ExecuteQuery(query);
            ShowCustomers();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
            }
            string query = string.Format("delete from Customers where Id={0};", lastSelectedProductKey);

            ExecuteQuery(query);
            ClearAllFields();
            ShowCustomers();

        }
        private void ClearAllFields()
        {
            txtBoxName.Text = "";
           // txtBoxID.Text = "";
            txtBoxAdress.Text = "";
            txtBoxTotalPrice.Text = "";
        }
        private void ShowCustomers()
        {
            databaseConnection.Open();

            string query = "select * from Customers";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            CustomerDGV.DataSource = dataSet.Tables[0];

            databaseConnection.Close();
        }
        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }
    }
}
