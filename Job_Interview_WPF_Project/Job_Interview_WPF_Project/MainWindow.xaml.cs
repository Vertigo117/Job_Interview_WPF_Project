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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Job_Interview_WPF_Project
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //string connectionString = Properties.Settings.Default.JIWP_DataBaseConnectionString;
            //SqlConnection connection = new SqlConnection(connectionString);

            //if (connection.State != System.Data.ConnectionState.Open)
            //{
            //    connection.Open();
            //}

            //SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM STUFF", connection);
            //DataTable stuff = new DataTable();
            //adapter.Fill(stuff);

            //Stuff.ItemsSource = stuff.DefaultView;


        }
    }
}
