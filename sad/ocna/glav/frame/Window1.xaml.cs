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
using System.Windows.Shapes;
using sad.bd;

namespace sad.ocna.glav.frame
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void vhodButton1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void vhodButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtpassword.Password))
            {
                MessageBox.Show($"Пожалуйста введите логин и пароль", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {

                var a = bd.conneckt.sadEntities.user.Where(z => z.Login1 == txtUsername.Text && z.Pass == txtpassword.Password).FirstOrDefault();
                if (a != null)
                {
                    ActualData.Id_User = a.id;
                    var b = a.Login1.FirstOrDefault();
                    if (a.Login1 == "Admin")
                    {
                        MessageBox.Show($"Добро пожаловать  {a.Login1}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);

                        //.Navigate(new lic1());

                    }
                    else if (a.Login1 == a.Login1)

                    {
                        MessageBox.Show($"Добро пожаловать  {a.Login1}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                       
                        //f1.Navigate(new dom());


                    }
                }
                else
                {
                    MessageBox.Show($"Логин или пароль не верный!\n Пожалуйста попробуйте ещё раз", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
    
}
