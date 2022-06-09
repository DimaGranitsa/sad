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
using System.Diagnostics;
namespace sad.ocna.glav
{
    /// <summary>
    /// Логика взаимодействия для _1sglavocno.xaml
    /// </summary>
    public partial class _1sglavocno : Page
    {
        public _1sglavocno()
        {
            InitializeComponent();
            f1.Navigate(new glav.frame.glavnay());
        }

        private void f1_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.glavnay());
        }

        private void kill_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void progect_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.proect());
        }

        private void product_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.producwba());
        }
    }
}
