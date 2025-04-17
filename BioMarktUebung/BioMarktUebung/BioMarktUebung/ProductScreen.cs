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
        public ProductScreen()
        {
            InitializeComponent();

            //DB Start
            databaseConnection.Open();

            string query = "select * from Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource= dataSet.Tables[0];


            //DB End
            databaseConnection.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
