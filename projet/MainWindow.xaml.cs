using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
 

namespace projet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        SqlConnection cn =  new SqlConnection("Data Source = DESKTOP-6DKDTL0; Initial catalog = pclient; Integrated Security = true;");
        DataSet ds = new DataSet();
        SqlDataAdapter ad = new SqlDataAdapter();
        

        private void MainWindow_Load(object sender, EventArgs e)
        {

            ad = new SqlDataAdapter("Select * From Client", cn);
            ad.Fill(ds, "Client");
            dataGridView1.DataSource = ds.Tables["client"];
          


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_supprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        
        }

     
    }


}
