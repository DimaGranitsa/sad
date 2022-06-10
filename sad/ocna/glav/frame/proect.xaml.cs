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
    /// Логика взаимодействия для proect.xaml
    /// </summary>
    public partial class proect : Page
    {
        public proect()
        {
            InitializeComponent();
            pan.ItemsSource = bd.conneckt.sadEntities.progekt.ToList();
            podrazdel1.ItemsSource = bd.conneckt.sadEntities.progekt.ToList().OrderBy(s => s.tipproe )/*.Where(s => s.tip == 2).Where(s => s.tip == 3)*/;
            podrazdel2.ItemsSource = bd.conneckt.sadEntities.progekt.ToList().Where(s => s.tip == 1)/*.Where(s => s.tip == 2).Where(s => s.tip == 3)*/;


        }

        private void podrazdel1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = podrazdel1.SelectedItem as bd.progekt;
            podrazdel1.ItemsSource = bd.conneckt.sadEntities.progekt/*.Where(s => s.tip == 1)*/.ToList().Where(z => z.tipproe == b.tipproe);
        }

        private void podrazdel2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = podrazdel2.SelectedItem as bd.progekt;
            podrazdel2.ItemsSource = bd.conneckt.sadEntities.progekt/*.Where(s => s.tip == 1)*/.ToList().Where(z => z.tipprodukct == b.tipprodukct);
        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
