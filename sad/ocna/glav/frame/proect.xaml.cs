﻿using System;
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
        }

        private void podrazdel1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //podrazdel1.Text =.SelectedItem.ToString();
        }

        private void podrazdel2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void pan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
