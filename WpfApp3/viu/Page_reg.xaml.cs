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

namespace WpfApp3.viu
{
    /// <summary>
    /// Логика взаимодействия для Page_reg.xaml
    /// </summary>
    public partial class Page_reg : Page
    {
        public Page_reg()
        {
            InitializeComponent();
        }

        private void avtoriz_bth_Click(object sender, RoutedEventArgs e)
        {
            if (passw1.Password == passw2.Password)
            {
                testTable user = new testTable();
                user.login1 = TxbLogin.Text;
                user.password1 = passw1.Password;

                var role = (CmbRole.SelectedItem as Role);
                user.roleid = role.id;

                Class1.db.testTable.Add(user);
                Class1.db.SaveChanges();
                MessageBox.Show($"Пользователь добавлен");

                Class_avto.avto_obj.Navigate(new Page_qw());
            }
            else 
            {
                MessageBox.Show("Ошибка " + "Проверьте пароли");
            }
        }

        private void poz_bth_Click(object sender, RoutedEventArgs e)
        {
            Class_avto.avto_obj.GoBack();  
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CmbRole.ItemsSource = Class1.db.Role.ToList();
        }
    }
}
