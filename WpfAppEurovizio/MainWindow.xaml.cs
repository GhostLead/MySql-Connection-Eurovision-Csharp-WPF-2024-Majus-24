using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppEurovizio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=eurovizio;";
        private MySqlConnection connection;
        List<Dal> adatok;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void dgDal_Loaded(object sender, RoutedEventArgs e)
        {
            adatok = new List<Dal>();

            try
            {
                connection = new MySqlConnection(connectionstring);
                connection.Open();
                string queryText = "SELECT id,ev,orszag,eloado,cim,helyezes,pontszam FROM dal ORDER BY id";
                MySqlCommand query = new MySqlCommand(queryText, connection);
                query.CommandTimeout = 60;
                MySqlDataReader reader = query.ExecuteReader();
                while (reader.Read())
                {
                    adatok.Add(new Dal(reader));
                }
                reader.Close();
                connection.Close();
                dgDal.ItemsSource = adatok;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
