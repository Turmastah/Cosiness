using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Cosiness.DataBase;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для BuyerCatalog.xaml
    /// </summary>
    public partial class BuyerCatalog : Window
    {
        public BuyerCatalog()
        {
            InitializeComponent();
            if (AppState.Get("userType") == "guest")         //Определение типа пользователя и скрытие кнопок если потребуется
            {
                AddBasket.Visibility = Visibility.Hidden;
                ClearBasket.Visibility = Visibility.Hidden;
                Menu.Visibility = Visibility.Hidden;
            }
            if (!(bool)AppState.Get("isLogin"))
            {
                AuthView authView = new AuthView();
                authView.Show();
                this.Close();
            }

            CosinessEntities Comfort = new CosinessEntities(); //Получение данных
            productsListView.ItemsSource = Comfort.Product.ToList();

            this.checkBasketCount();
        }

        private void ClearBusket_Click(object sender, RoutedEventArgs e) //Очистка корзины
        {
            Basket.ClearBasket();
            this.checkBasketCount();
        }


        private void checkBasketCount() //Проверка количества товаров в корзине
        {
            ClearBasket.Visibility = Visibility.Hidden;
            if (Basket.getBasket().Count > 0)
            {
                ClearBasket.Visibility = Visibility.Visible;
            }
        }

        private void SearchTextChanged(object sender, TextChangedEventArgs e) //Поиск при вписывании чего либо в соответствующий блок
        {
            string text = SearchInput.Text;
            List<Product> Product = Utility.searchproducts(text);
            productsListView.ItemsSource = Product;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //Возврат в меню покупателя
        {
            BuyerMenu window = new BuyerMenu();
            window.Show();
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e) //добавление товара в корзину
        {
            var current = (Product)productsListView.SelectedItem;
            if (current == null)
            {
                MessageBox.Show("Выберите товар");
            }
            else
            {
                Basket.addproduct((int)current.Product_ID);
                this.checkBasketCount();
            }    

        }
    }
}
