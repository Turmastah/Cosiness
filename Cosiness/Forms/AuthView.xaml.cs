using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Cosiness.DataBase;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для AuthView.xaml
    /// </summary>
    public partial class AuthView : Window  //Определение данных
    {
        int tries;
        static string symbols = "1234567890";
        static Random r = new Random();
        static bool cc = false;
        public AuthView()
        {
            InitializeComponent();
            CaptchaGrid.Visibility = Visibility.Hidden;
        }

        private void ButtonEnterApp_Click(object sender, RoutedEventArgs e) //Функция входа
        {
            User userData = new User();

            userData = CosinessEntities.GetContext().User.Where(u => u.Login == LoginInput.Text && u.Password == PasswordInput.Password).FirstOrDefault();
            if (tries >= 3 && userData == null)
            {
                DateTime date = DateTime.Now;
                MessageBox.Show($"Вы ввели неправильные данные больше трёх раз. Система заблокирована на {10} секунд"); //Система безопасности - при > 3 попытках входа - блокирует кнопки на 10 секунд
                while (date.AddSeconds(10) > DateTime.Now)
                {
                    LoginInput.IsEnabled = false;
                    PasswordInput.IsEnabled = false;
                    ButtonEnterApp.IsEnabled = false;
                }
                LoginInput.IsEnabled = true;
                PasswordInput.IsEnabled = true;
                ButtonEnterApp.IsEnabled = true;
            }
            if (LoginInput.Text == "" || PasswordInput.Password == "")
            {
                if (cc && CapthaInput.Text != "")  //Проверка введенной  капчи на правильность
                {
                    MessageBox.Show("Неверная капча");
                    updCaptcha();
                    tries++;
                    return;
                }
                MessageBox.Show("Убедитесь что все поля введены");
            }

            else
            {
                if (cc)
                {
                    if (CapthaInput.Text != Captcha.Text)
                    {
                        MessageBox.Show("Неверная капча");
                        updCaptcha();
                        tries++;
                        return;
                    }
                }

                User our_user = Utility.GetUserByLogin(LoginInput.Text);
                if (our_user != null && Utility.VerifyPassword(PasswordInput.Password, our_user.Password)) //Находим пользователя
                {
                    AppState.Add("isLogin", true);
                    AppState.Add("userType", "our_user");
                    AppState.Add("our_user", our_user);

                    string ConnectionString = "Data source=TURMASTAH;initial catalog=Cosiness;integrated security=True";  //Подключение к БД для реализации SQL запроса напрямую

                    SqlConnection con = new SqlConnection(ConnectionString);

                    con.Open();

                    int usID = (int)our_user.User_ID;
                    DateTime LastLoginData = DateTime.Now;

                    string Query = $"UPDATE [User] SET Last_login_date = '{LastLoginData}' WHERE User_ID = '{usID}'"; //SQL запрос на обновление даты последнего входа
                    SqlCommand cmd = new SqlCommand(Query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Дата последнего входа обновлена");

                    CosinessEntities.GetContext().SaveChanges();
                    if (our_user.Role_ID == 1)   //Проверка ролей и вход на соответствующие меню
                    {
                        MessageBox.Show("Добро пожаловать администратор!");
                        PersonalMenu adminPanel = new PersonalMenu();
                        adminPanel.Show();
                        Close();
                        return;
                    }
                    else if (our_user.Role_ID == 3)
                    {
                        CosinessEntities.GetContext().SaveChanges();
                        MessageBox.Show("Добро пожаловать менеджер!");
                        PersonalMenu adminPanel = new PersonalMenu();
                        adminPanel.Show();
                        Close();
                        return;
                    }
                    else if (our_user.Role_ID == 2)
                    {
                        CosinessEntities.GetContext().SaveChanges();
                        MessageBox.Show("Удачных покупок!");
                        BuyerMenu buyerMenu = new BuyerMenu();
                        buyerMenu.Show();
                        Close();
                        return;
                    }
                }
                else
                {
                    CaptchaGrid.Visibility = Visibility.Visible;
                    cc = true;
                    updCaptcha();
                    tries++;
                    MessageBox.Show("Неверный логин или пароль. Пройдите проверку");
                }
            }
        }


        private void updCaptcha() //Случайное построение капчи
        {
            var index = r.Next(symbols.Length);
            var index2 = r.Next(symbols.Length);
            var index3 = r.Next(symbols.Length);
            var index4 = r.Next(symbols.Length);

            Captcha.Text = index.ToString() + index2.ToString() + index3.ToString() + index4.ToString();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Выход из программы
        {
            Application.Current.Shutdown();
        }

        private void ButtonEnterAsGuest_Click(object sender, RoutedEventArgs e) //Вход как гость
        {
            MessageBox.Show("Для того чтобы сделать заказ - зарегистрируйтесь");
            AppState.Add("isLogin", true);
            AppState.Add("userType", "guest");
            BuyerMenu window = new BuyerMenu();
            window.Show();
            this.Close();
        }

        private void Registration_Click(object sender, RoutedEventArgs e) //Переход на страницу регистрации
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            Close();
        }
    }
}