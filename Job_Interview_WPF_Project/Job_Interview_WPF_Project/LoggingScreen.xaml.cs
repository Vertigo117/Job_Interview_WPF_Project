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
using System.Windows.Shapes;

namespace Job_Interview_WPF_Project
{
    /// <summary>
    /// Логика взаимодействия для LoggingScreen.xaml
    /// </summary>
    public partial class LoggingScreen : Window
    {
        public LoggingScreen()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            UserInfo ui = new UserInfo();
            ui.UserName = txtUsername.Text;
            ui.Password = txtPassword.Password;

            if (ui.CheckUserInfo() == true)
            {
                MainWindow dashboard = new MainWindow();
                dashboard.Show();
                this.Close();
            }
            else
                MessageBox.Show("Login failure. Check the Username and Password");
        }
    }
}
