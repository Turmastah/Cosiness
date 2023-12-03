using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Cosiness.DataBase;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для BasketView.xaml
    /// </summary>
    public partial class BasketView : Window         //Определяем локальные классовые данные
    {
        private readonly List<Product> basketItems = new List<Product>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            resultSum.Content = $"Итоговая сумма:\n{basketItems.Sum(product => product.Price)}"; //Вывод суммы товаров в корзине
        }
        private void CheckBasketCount() //Проверка численности для показа кнопок и т.д
        {
            Del.Visibility = Visibility.Hidden;
            Buy.Visibility = Visibility.Hidden;
            if (Basket.getBasket().Count > 0)
            {
                Buy.Visibility = Visibility.Visible;
                Del.Visibility = Visibility.Visible;
            }
        }
        public BasketView()  //Получаем данные
        {
            InitializeComponent();
            Points.ItemsSource = CosinessEntities.GetContext().Pick_up_Point.ToList();
            basketItems = new List<Product>();
            foreach (int id in Basket.getBasket())
            {
                basketItems.Add(Utility.GetProduct(id));
            }

            BasketListView.ItemsSource = basketItems;

            if (AppState.Get("userType") == "our_user")  //Вывод данных о пользователе - иначе если это гость, то он заполняет свое ФИО
            {
                NameBl.Text = $"Ваше имя: \n{AppState.Get("our_user").Name}";
                SurnameBl.Text = $"Ваша фамилия: \n{AppState.Get("our_user").Surname}";
                PatronymicBl.Text = $"Ваше отчество: \n{AppState.Get("our_user").Patronymic}";
                NameInput.Visibility = Visibility.Hidden;
                SurnameInput.Visibility = Visibility.Hidden;
                PatronymicInput.Visibility = Visibility.Hidden;
            }
            if (AppState.Get("userType") == "guest")
            {
                NameInput.Visibility = Visibility.Visible;
                SurnameInput.Visibility = Visibility.Visible;
                PatronymicInput.Visibility = Visibility.Visible;
            }

            UpdateResultSum();
            this.CheckBasketCount();

        }

        private void Back_Click(object sender, RoutedEventArgs e) //Возврат в меню покупателя
        {
            BuyerMenu window = new BuyerMenu();
            window.Show();
            this.Close();
        }

        private void Del_Click(object sender, RoutedEventArgs e) //Удаление товара из корзины
        {
            System.ComponentModel.IEditableCollectionView items = BasketListView.Items;

            if (BasketListView.SelectedItem == null)
            {
                string msg = "Выберите удаляемый товар ";
                MessageBox.Show(msg);
                return;
            }
            else
            {
                Product selectedItem = BasketListView.SelectedItems[0] as Product;  //Получение выделенных товаров в таблице - соотнесение - удаление
                Basket.Delete((int)selectedItem.Product_ID);
                items.Remove(BasketListView.SelectedItem);
                UpdateResultSum();
            }
        }

        private void UpdateResultSum() //Обновление суммы заказа
        {
            resultSum.Content = $"Итоговая сумма:\n{basketItems.Sum(product => product.Price)}";
        }

        public void CreateOrder()
        {
            var points = Points.SelectedIndex; //Получение точки для сбора заказа
            if (points == 0)
            {
                points = 1;
            }
            else points++;
            var status = 1;

            if (AppState.Get("userType") == "guest") //Создание заказа для гостя и для обычного пользователя
            {
                Utility.createOrder(status, points, NameInput.Text, SurnameInput.Text, PatronymicInput.Text, null);
                MessageBox.Show("Заказ создан");
            }
            else
            {
                Utility.createOrder(status, points, AppState.Get("our_user").Name, AppState.Get("our_user").Surname, AppState.Get("our_user").Patronymic, AppState.Get("our_user").User_ID);
                MessageBox.Show("Заказ создан");
            }
        }

        private void Buy_Click(object sender, RoutedEventArgs e) //Оформление заказа с помощью кнопки
        {
            if (AppState.Get("userType") == "guest")
            {
                if (NameInput.Text == "" || SurnameInput.Text == "" || PatronymicInput.Text == "" || Points.Text == "")
                {
                    string msg = "Введите ваши данные ";
                    MessageBox.Show(msg);
                    return;
                }
                CreateOrder();
            }
            else if (AppState.Get("userType") == "our_user")
            {
                CreateOrder();
            }
        }

        private void DelMEnu_Click(object sender, RoutedEventArgs e) //Удаление с помощью кнопки
        {
            System.ComponentModel.IEditableCollectionView items = BasketListView.Items;

            if (BasketListView.SelectedItem == null)
            {
                string msg = "Выберите удаляемый товар ";
                MessageBox.Show(msg);
                return;
            }
            else
            {
                Product selectedItem = BasketListView.SelectedItems[0] as Product; //Получение выделенных товаров в таблице - соотнесение - удаление
                Basket.Delete((int)selectedItem.Product_ID);
                items.Remove(BasketListView.SelectedItem);
                UpdateResultSum();
            }

        }
    }
}
