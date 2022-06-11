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

namespace sad.ocna.glav.frame.admin
{
    /// <summary>
    /// Логика взаимодействия для _2.xaml
    /// </summary>
    public partial class _2 : Page
    {
        public _2()
        {
            InitializeComponent();
            std.ItemsSource = bd.conneckt.sadEntities.user.ToList();
        }

        private void add_students_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
std.ItemsSource = bd.conneckt.sadEntities.user.ToList().Where(z => z.Login1.Contains(serach_tb.Text)); //поиск по имени
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void std_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
