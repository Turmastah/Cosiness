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

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для PersonalMenu.xaml
    /// </summary>
    public partial class PersonalMenu : Window
    {
        public PersonalMenu()
        {
            InitializeComponent();  //Получение роли пользователя - скрытие ненужных роли переходов
            {
                var UR = AppState.Get("our_user").Role_ID;
                if (UR == 1)
                {
                    toUsers.Visibility = Visibility.Visible;
                    toPerOrd.Visibility = Visibility.Hidden;
                }
                if (UR == 3)
                {
                    toPerCat.Visibility = Visibility.Hidden;
                    toUsers.Visibility = Visibility.Hidden;
                }
                else 
                {
                    userNameBox.Content = AppState.Get("our_user").Login;
                }
            }
        }

        private void Execution_CanExecuted(object sender, ExecutedRoutedEventArgs e) //Выход из приложения
        {
            Application.Current.Shutdown();
        }

        private void ToPerOrd_Click(object sender, RoutedEventArgs e) //Переход к заказам покупателей
        {
            PersonalOrders perord = new PersonalOrders();
            perord.Show();
            this.Close();
        }

        private void ToPerCat_Click(object sender, RoutedEventArgs e) //Переход к каталогу сотрудников
        {
            PersonalCatalog percat = new PersonalCatalog();
            percat.Show();
            this.Close();
        }

        private void ToUsers_Click(object sender, RoutedEventArgs e) //Переход к пользователям
        {
            PersonalUsers users = new PersonalUsers();
            users.Show();
            this.Close();
        }
    }
}
