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
    /// Логика взаимодействия для cvet.xaml
    /// </summary>
    public partial class cvet : Page
    {
        public cvet()
        {
            InitializeComponent();
            pan.ItemsSource = null;
            pan.ItemsSource = bd.conneckt.sadEntities.hvoysvet.Where(z => z.tipprod == ActualData.tipProduct).ToList();
            pan1.ItemsSource = null;
            pan1.ItemsSource = bd.conneckt.sadEntities.hvoysvet.OrderByDescending(z => z.tipprod == ActualData.tipProduct).ToList();
        }

        private void az_Click(object sender, RoutedEventArgs e)
        {
            pan.ItemsSource = bd.conneckt.sadEntities.hvoysvet.ToList().OrderBy(z => z.name); /*сортеровка по имени*/
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            pan.ItemsSource = bd.conneckt.sadEntities.hvoysvet.ToList().Where(z => z.name.Contains(serach_tb.Text)); //поиск по имени
        }
    }
}
