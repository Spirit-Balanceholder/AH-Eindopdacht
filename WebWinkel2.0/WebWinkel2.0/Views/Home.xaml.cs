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
using WebWinkel2._0.Views;

namespace WebWinkel2._0
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Login lg = new Login();
            lg.ShowDialog();
        }

       
        private void btnklant_Click(object sender, RoutedEventArgs e)
        {
            StartWindow sw = new StartWindow();
            sw.InitializeComponent();
            sw.Show();
        }

        private void btnadmin_Click(object sender, RoutedEventArgs e)
        {
            AdminStartWindow asw = new AdminStartWindow();
            asw.InitializeComponent();
            asw.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
