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
using sad.bd;

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
           
            //f1.ItemsSource = null;
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 1).FirstOrDefault();
            ActualData.tipProduct = a.Id;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void urn_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 2).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void cvet_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 3).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void vel_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 4).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void sanuz_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 5).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
       
        }

        private void dog_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 6).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

       

        private void f1_Navigated_2(object sender, NavigationEventArgs e)
        {

        }

        private void op_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 7).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void ar_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 8).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void pro_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 9).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void drevo_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == 10).FirstOrDefault();
            ActualData.tipProduct = a.tipProduct.Value;
            f1.Navigate(new glav.frame.framespomog.arhitektura());
        }

        private void cvet1_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.hvoysvet.Where(z => z.tipprod == 1).FirstOrDefault();
            ActualData.tipProduct = a.tipprod.Value;
            f1.Navigate(new glav.frame.framespomog.cvet());
        }

        private void hvoi_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.hvoysvet.Where(z => z.tipprod == 2).FirstOrDefault();
            ActualData.tipProduct = a.tipprod.Value;
            f1.Navigate(new glav.frame.framespomog.cvet());
        }

        private void dex_Click(object sender, RoutedEventArgs e)
        {
            var a = bd.conneckt.sadEntities.hvoysvet.Where(z => z.tipprod == 3).FirstOrDefault();
            ActualData.tipProduct = a.tipprod.Value;
            f1.Navigate(new glav.frame.framespomog.cvet());
        }
    }
}
