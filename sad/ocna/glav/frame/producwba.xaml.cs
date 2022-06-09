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

namespace sad.ocna.glav.frame
{
    /// <summary>
    /// Логика взаимодействия для producwba.xaml
    /// </summary>
    public partial class producwba : Page
    {
        public producwba()
        {
            InitializeComponent();
        }

        private void skam_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
            //f1.ItemsSource = null;
        }

        private void urn_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void cvet_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void vel_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void sanuz_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void dog_Click(object sender, RoutedEventArgs e)
        {
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

       

        private void f1_Navigated_2(object sender, NavigationEventArgs e)
        {

        }
    }
}
