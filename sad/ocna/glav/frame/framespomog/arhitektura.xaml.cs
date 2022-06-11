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
    /// Логика взаимодействия для arhitektura.xaml
    /// </summary>
    public partial class arhitektura : Page
    {
        public arhitektura()
        {
            InitializeComponent();
            pan.ItemsSource = null;
            pan.ItemsSource = bd.conneckt.sadEntities.productnotrost.Where(z => z.tipProduct == ActualData.tipProduct).ToList();
            pan1.ItemsSource = null;
            pan1.ItemsSource = bd.conneckt.sadEntities.productnotrost.OrderByDescending(z => z.tipProduct == ActualData.tipProduct).ToList();
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            pan.ItemsSource = bd.conneckt.sadEntities.productnotrost.ToList().Where(z => z.name.Contains(serach_tb.Text)); //поиск по имени
        }

        private void az_Click(object sender, RoutedEventArgs e)
        {
            pan.ItemsSource = bd.conneckt.sadEntities.productnotrost.ToList().OrderBy(z => z.name); /*сортеровка по имени*/
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
