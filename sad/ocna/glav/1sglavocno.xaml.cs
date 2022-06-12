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
using sad.bd;

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
            //if (ActualData.Id_User == 0)
            //{
            //    car.IsEnabled = false;
            //}
            //else { car.IsEnabled = true; }
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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            f1.Navigate(new glav.frame.admin.login());
        }

        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            //if (ActualData.Id_User == 0)
            //{
            //    car.IsEnabled = false;
            //}
            //else { car.IsEnabled = true; }
        }

        private void car_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.kar());
        }

        private void ob_Click(object sender, RoutedEventArgs e)
        {
            //if (ActualData.Id_User == 0)
            //{
            //    car.IsEnabled = false;
            //}
            //else { car.IsEnabled = true; }
        }
    }
}
