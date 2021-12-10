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
    /// Логика взаимодействия для Page_qw.xaml
    /// </summary>
    public partial class Page_qw : Page
    {
        public Page_qw()
        {
            InitializeComponent();
        }

        private void voz_bth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void delete_bth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = GridUser.SelectedItem as testTable;
                var CurrentUser = Class1.db.testTable.FirstOrDefault(Item => Item.Id == user.Id);
                if (CurrentUser != null)
                {
                    if (MessageBox.Show($"Удалить пользователя с логином :{CurrentUser.login1}?", "Подтвердите действие!", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                    {
                        Class1.db.testTable.Remove(CurrentUser);
                        Class1.db.SaveChanges();
                        MessageBox.Show($"Пользователь с логином :{CurrentUser.login1} был удален!");
                        GridUser.ItemsSource = Class1.db.testTable.ToList();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }


        }

        private void add_bth_Click(object sender, RoutedEventArgs e)
        {
            Class_avto.avto_obj.Navigate(new Page_reg());
        }

        private void pech_bth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void izm_bth_Click(object sender, RoutedEventArgs e)
        {

        }

        private void riges_bth_Click(object sender, RoutedEventArgs e)
        {
            Class_avto.avto_obj.GoBack();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            GridUser.ItemsSource = Class1.db.testTable.ToList();
        }

        private void poisk_bth_Click(object sender, RoutedEventArgs e)
        {

            var DelUs = Class1.db.testTable.Where(user => user.login1 == poisk.Text).ToList();
            if (DelUs.Count == 0)
            {
                MessageBox.Show("Пользователя с таким логином нет в базе");
                GridUser.ItemsSource = Class1.db.testTable.ToList();   
            }
            else
            {
                GridUser.ItemsSource = DelUs;
            }
          

        }
    }
}
