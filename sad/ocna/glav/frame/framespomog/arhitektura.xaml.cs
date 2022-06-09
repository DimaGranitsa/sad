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
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            //std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().Where(z => z.name.Contains(serach_tb.Text)); //поиск по имени
        }

        private void az_Click(object sender, RoutedEventArgs e)
        {
            //std.ItemsSource = bd.connect.harleyEntities.otzov3.ToList().OrderBy(z => z.name); /*сортеровка по имени*/
        }
    }
}
