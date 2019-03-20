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
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database1DataSet Database1DataSet;
        private Database1DataSetTableAdapters.STUFFTableAdapter STUFFTableAdapter;
        private System.Windows.Data.CollectionViewSource sTUFFViewSource;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BindDatabase();
            
        }

        private void BindDatabase()
        {
            Database1DataSet = ((WpfApp1.Database1DataSet)(this.FindResource("database1DataSet")));

            STUFFTableAdapter = new WpfApp1.Database1DataSetTableAdapters.STUFFTableAdapter();
            STUFFTableAdapter.Fill(Database1DataSet.STUFF);
            sTUFFViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sTUFFViewSource")));
            sTUFFViewSource.View.MoveCurrentToFirst();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                STUFFTableAdapter.Update(Database1DataSet.STUFF);
                MessageBox.Show("Data was successfully updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Insert insert = new Insert();
            insert.Show();
           
        }

       

        private void Main_Window_Activated(object sender, EventArgs e)
        {
            BindDatabase();
        }
    }
}
