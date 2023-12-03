using System.Windows;
using System.Windows.Input;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для BuyerMenu.xaml
    /// </summary>
    public partial class BuyerMenu : Window
    {
        public BuyerMenu()
        {
            InitializeComponent();  //Определяем тип пользователя и выводим его логин на экран
            {
                if (AppState.Get("userType") == "guest")
                {
                    toBuyOrd.Visibility = Visibility.Hidden;
                    userNameBox.Content = "Гость";
                }
                else
                {
                    userNameBox.Content = AppState.Get("our_user").Login;
                }
            }
        }

        private void CloseCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Выход из программы
        {
            Application.Current.Shutdown();
        }

        private void CloseCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность выполнения
        {
            e.CanExecute = true;
        }

        private void toBuyCat_Click(object sender, RoutedEventArgs e) //Переход в каталог покупателя
        {
            BuyerCatalog buycat = new BuyerCatalog();
            buycat.Show();
            this.Close();
        }

        private void toBucket_Click(object sender, RoutedEventArgs e) //Переход в корзину
        {
            BasketView buyord = new BasketView();
            buyord.Show();
            this.Close();
        }
    }
}
