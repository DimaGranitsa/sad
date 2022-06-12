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

namespace sad.ocna.glav.frame.framespomog
{
    /// <summary>
    /// Логика взаимодействия для kar.xaml
    /// </summary>
    public partial class kar : Page
    {
        public kar()
        {
            InitializeComponent();
            CBReceive.ItemsSource = bd.conneckt.sadEntities.hvoysvet/*.Where(z => z.tipprod == ActualData.tipProduct)*/.ToList();
            CBReceive.ItemsSource = bd.conneckt.sadEntities.productnotrost/*.Where(z => z.tipprod == ActualData.tipProduct)*/.ToList();
            //pan.ItemsSource = bd.conneckt.sadEntities.progekt.ToList();
            //DGProducts.ItemsSource = bd.conneckt.sadEntities.hvoysvet.ToList().OrderBy(s => s.tipProduct)/*.Where(s => s.tip == 2).Where(s => s.tip == 3)*/;
            //DGProducts.ItemsSource = bd.conneckt.sadEntities.productnotrost.ToList().Where(s => s.tip == 1)/*.Where(s => s.tip == 2).Where(s => s.tip == 3)*/;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
//var b = CBProduct.SelectedItem as bd.productnotrost;
//            CBProduct.ItemsSource = bd.conneckt.sadEntities.productnotrost/*.Where(s => s.tip == 1)*/.ToList().(z => z.tipProduct == b.tipProduct);
        }

        private void DGProducts_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            var b = CBProduct.SelectedItem as bd.productnotrost;
            CBProduct.ItemsSource = bd.conneckt.sadEntities.productnotrost/*.Where(s => s.tip == 1)*/.ToList().Where(z => z.tipProduct == b.tipProduct);
        }

        private void CBReceive_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
