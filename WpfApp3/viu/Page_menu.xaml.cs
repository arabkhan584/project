using EllipticCurve.Utils;
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
using WpfApp3.Class;
using WpfApp3.model;
using WpfApp3.viu;

namespace WpfApp3.viu
{
    /// <summary>
    /// Логика взаимодействия для Page_menu.xaml
    /// </summary>
    public partial class Page_menu : Page
    {
        public Page_menu()
        {
            InitializeComponent();
            if (Properties.Settings.Default.UserLogin != "" && Properties.Settings.Default.UserPass != "")
            {
                login.Text = Properties.Settings.Default.UserLogin;
                pass.Password = Properties.Settings.Default.UserPass;
            }
        }

        private void bth_vkhod_Click(object sender, RoutedEventArgs e)
        {


            var user = Class1.db.testTable.FirstOrDefault(y => y.login1 == login.Text && y.password1 == pass.Password);

            if (user != null)
            {
                Class_avto.avto_obj.Navigate(new Page_qw());
            }
            //if (login.Text == "admin" && pass.Password == "admin")
            //{
            //    // поиск пользователя 

            //    Class_avto.avto_obj.Navigate(new Page_qw());



            //}
            else
            {
                MessageBox.Show("Ошибка");
            }

            Properties.Settings.Default.UserLogin = login.Text;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.UserPass = pass.Password;
            Properties.Settings.Default.Save();



        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            Class_avto.avto_obj.Navigate(new Page_reg());

        }
    }
}
