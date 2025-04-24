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
    }
}
