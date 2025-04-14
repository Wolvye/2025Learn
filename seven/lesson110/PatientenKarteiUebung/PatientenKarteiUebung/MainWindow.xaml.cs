using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace PatientenKarteiUebung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string dirPath = @"C:\Users\Wolvy\OneDrive\Desktop\TestOrdner\"; //Merke dir das @ wenn du mit / arbeitest!
        public const string FileExt = ".txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            
            string content = textBoxContent.Text;
            string filename = textBoxFileName.Text;

            using (FileStream fs = File.Create(dirPath + filename + FileExt)) //Using ist disposted- es wird der arbeitsspeicher wieder frei gegeben
            {
                Byte[] contentConvertedToByteArrey = Encoding.ASCII.GetBytes(content);
                fs.Write(contentConvertedToByteArrey, 0, contentConvertedToByteArrey.Length);
            }

            MessageBox.Show("Datei wurde angelegt"); //Feedback
        }

        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
            string filename = textBoxFileName.Text;
            using (FileStream fs = File.OpenRead(dirPath + filename + FileExt))
            {
                using (StreamReader sr = new StreamReader(fs)) //Der StreamReader ist KEIN Stream! 
                {
                    string content = sr.ReadToEnd();
                    textBoxContent.Text = content;
                }
            }
        }
    }
}