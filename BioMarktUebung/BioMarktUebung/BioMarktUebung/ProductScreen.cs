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
    public partial class ProductScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Wolvy\OneDrive\Dokumente\Pro-Natur Biomarkt Übung.mdf;Integrated Security = True; Connect Timeout = 30");
        private int lastSelectedProductKey;
        public ProductScreen()
        {
            InitializeComponent();
            ShowProducts();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBoxName.Text == ""
                || txtBoxBrand.Text == ""

                || comboBoxCategory.Text == ""
                || txtBoxPrice.Text == "")
            {
                MessageBox.Show("Bitte fülle alle Werte/Felder aus.");
                return;
            }
            string productName = txtBoxName.Text;
            string productBrand = txtBoxBrand.Text;
            string productCategory = comboBoxCategory.Text;
            string productPrice = txtBoxPrice.Text;

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')", productName, productBrand, productCategory, productPrice);

            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
            }
            string productName = txtBoxName.Text;
            string productBrand = txtBoxBrand.Text;
            string productCategory = comboBoxCategory.Text;
            string productPrice = txtBoxPrice.Text;

            string query = string.Format("update Products set Name ='{0}', Brand ='{1}', Category = '{2}', Price = '{3}' where Id={4}"
                , productName, productBrand, productCategory, productPrice,lastSelectedProductKey);
            ExecuteQuery(query);
            ShowProducts();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus");
            }
            string query = string.Format("delete from Products where Id={0};", lastSelectedProductKey);

            ExecuteQuery(query);
            ClearAllFields();
            ShowProducts();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void ClearAllFields()
        {
            txtBoxName.Text = "";
            txtBoxBrand.Text = "";
            txtBoxPrice.Text = "";
            comboBoxCategory.Text = "";
            comboBoxCategory.SelectedItem = null;
        }
        private void ShowProducts()
        {
            //DB Start
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];


            //DB End
            databaseConnection.Close();
        }
        private void ExecuteQuery(string query)
        {
            databaseConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();
            databaseConnection.Close();
        }
        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBoxName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            txtBoxPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();
            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;

        }
    }
}
