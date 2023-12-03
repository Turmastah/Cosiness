using Cosiness.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cosiness
{
    public class Utility
    {

        private static CosinessEntities Comfort = new CosinessEntities();

        public static User GetUserByLogin(string login) //Получение данных пользователя по логину
        {
            return Comfort.User.FirstOrDefault(our_user => our_user.Login == login);
        }

        public static Product GetProduct(int id) //Нахождение продукта по ID
        {
            return Comfort.Product.Find(id);
        }
        public static void createOrder(dynamic status, dynamic point, string Name, string Surname, string Patronymic, dynamic User_ID = null) //Создание заказа
        {
            Order our_order = new Order();
            our_order.Order_Date = DateTime.Now;
            our_order.User_ID = User_ID;
            our_order.Name = Name;
            our_order.Surname = Surname;
            our_order.Patronymic = Patronymic;
            our_order.Status_ID = status;
            our_order.Point_ID = point;

            Comfort.Order.Add(our_order);
            Comfort.SaveChanges();

            foreach (int id in Basket.getBasket())
            {

                Comfort.Order_List.Add(new Order_List() { Order_ID = our_order.Order_ID, Product_ID = GetProduct(id).Product_ID });
                Comfort.SaveChanges();
            }
        }

        public static void createUser(string login, string Name, string Surname, string Patronymic, string Password, int ADM) //Создание пользователя
        {
            Comfort.User.Add(new User() { Login = login, Name = Name, Surname = Surname, Patronymic = Patronymic, Password = Password , Role_ID = ADM });
            Comfort.SaveChanges();
        }

        public static string HashPassword(string Password) //Шифрование пароля
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPassword(string enteredPassword, string hashedPassword) //Расшифрование пароля
        {
            var enteredPasswordHash = HashPassword(enteredPassword);
            return string.Equals(enteredPasswordHash, hashedPassword, StringComparison.OrdinalIgnoreCase);
        }

        public static List<Product> getProductsOrder(int id) //Получение листа продуктов в заказе
        {
            List<Order_List> Order = Comfort.Order_List.Where(orders_list => orders_list.Order_ID == id).ToList();

            List<Product> ProductsList = new List<Product>();

            foreach (Order_List product in Order)
            {
                ProductsList.Add(GetProduct((int)product.Product_ID));
            }

            return ProductsList;
        }

        public static List<Order> GetUserOrders(int userID) //Получение заказов пользователя
        {
            return Comfort.Order.Where(our_order => our_order.User_ID == userID ).ToList();
        }

        public static List<Order> GetOrders() //Получение заказов
        {
            return Comfort.Order.ToList();
        }

        public static List<Product> Getproducts() //Получение продуктов
        {
            return Comfort.Product.ToList();
        }

        public static List<Product> searchproducts(string text) //Поиск продуктов
        {
            return Comfort.Product.Where(Product => Product.Name.ToLower().Contains(text)).ToList();
        }
    }
}
