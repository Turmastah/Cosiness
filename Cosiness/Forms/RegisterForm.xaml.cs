using System.Windows;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void Registration_Click(object sender, RoutedEventArgs e) //Функционал регистрации
        {
            if (loginInput.Text == "" || Password.Password == "" || password2.Password == "" || NameInput.Text == "" || SurnameInput.Text == "" || PatronymicInput.Text == "")
            {
                MessageBox.Show("Убедитесь, что все поля введены");
            }
            else
            {
                if (Password.Password != password2.Password)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return;
                }
                else if (Check_wordInput.Text == "ADMIN") //Для создания не покупателей - есть слова, что вписываются в скрытую форму слева над кнопкой. ADMIN и MANAGER соответствующе
                {
                    int ADM = 1;
                    Utility.createUser(loginInput.Text, NameInput.Text, SurnameInput.Text, PatronymicInput.Text, Utility.HashPassword(Password.Password), ADM);
                    MessageBox.Show("Вы зарегистрированы как администратор");
                    AuthView authView = new AuthView();
                    authView.Show();
                    Close();
                }
                else if (Check_wordInput.Text == "MANAGER")
                {
                    int ADM = 3;
                    Utility.createUser(loginInput.Text, NameInput.Text, SurnameInput.Text, PatronymicInput.Text, Utility.HashPassword(Password.Password), ADM);
                    MessageBox.Show("Вы зарегистрированы как менеджер");
                    AuthView authView = new AuthView();
                    authView.Show();
                    Close();
                }
                else
                {
                    int ADM = 2;
                    Utility.createUser(loginInput.Text, NameInput.Text, SurnameInput.Text, PatronymicInput.Text, Utility.HashPassword(Password.Password), ADM);
                    MessageBox.Show("Вы зарегистрированы как покупатель");
                    AuthView authView = new AuthView();
                    authView.Show();
                    Close();
                }
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e) //Возвращение на окно аутентификации 
        {
            AuthView window = new AuthView();
            window.Show();
            this.Close();
        }
    }
}
