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
            BindDataGrid();
        }

        static string connectionString = Properties.Settings.Default.JIWP_DataBaseConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);
        SqlCommandBuilder builder;
        SqlDataAdapter adapter;
        DataTable stuff;

        private void BindDataGrid()
        {
            
            

            //if (connection.State != System.Data.ConnectionState.Open)
            //{
            //    connection.Open();
            //}

            adapter = new SqlDataAdapter("SELECT * FROM STUFF", connection);
            stuff = new DataTable();
            adapter.Fill(stuff);

            Data.ItemsSource = stuff.DefaultView;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                builder = new SqlCommandBuilder(adapter);
                adapter.Update(stuff);
                MessageBox.Show("Update complete");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            //connection.Close();
        }
    }
}
