using Cosiness.DataBase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class PersonalUsers : Window
    {
        public PersonalUsers() //получение данных с таблиц
        {
            InitializeComponent();
            DataGridUser.ItemsSource = CosinessEntities.GetContext().User.ToList();
            RoleSearch.ItemsSource = CosinessEntities.GetContext().Role.ToList();
            РольChange.ItemsSource = CosinessEntities.GetContext().Role.ToList();
        }
        private bool isDirty = true;
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность удаления
        {
            e.CanExecute = isDirty;
        }
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Удаление выбранных элементов
        {
            var RemovingPers = DataGridUser.SelectedItems.Cast<User>().ToList();

            if (MessageBox.Show($"Удалить {RemovingPers.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    CosinessEntities.GetContext().User.RemoveRange(RemovingPers);
                    CosinessEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено");
                    DataGridUser.ItemsSource = CosinessEntities.GetContext().User.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            isDirty = false;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)//Возможность редактирования
        {
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Редактирование 
        {
            DataGridUser.IsReadOnly = false;
            DataGridUser.BeginEdit();
            isDirty = false;
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Сохранение данных
        {
            try
            {
                CosinessEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isDirty = true;
            DataGridUser.IsReadOnly = true;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность сохранения
        {
            e.CanExecute = !isDirty;
        }
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Функционал обновления
        {
            var context = CosinessEntities.GetContext();
            var changedEntries = context.ChangeTracker.Entries()
                .Where(x => x.State != EntityState.Unchanged).ToList();

            foreach (var entry in changedEntries)
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.CurrentValues.SetValues(entry.OriginalValues);
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
            DataGridUser.ItemsSource = null;
            DataGridUser.ItemsSource = CosinessEntities.GetContext().User.ToList();
            MessageBox.Show("Отмена действия");
            isDirty = true;
            DataGridUser.IsReadOnly = true;
        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность обернуть ошибку вспять
        {
            e.CanExecute = !isDirty;
        }

        private void RoleSearchButton_Click(object sender, RoutedEventArgs e) //Поиск по нажатию кнопки
        {
            string RolName = RoleSearch.Text;
            Role secIDQuery = (Role)CosinessEntities.GetContext().Role.Where(c => c.Role_name.Contains(RolName)).FirstOrDefault();
            int secID = secIDQuery.Role_ID;
            DataGridUser.ItemsSource = null;
            DataGridUser.ItemsSource = CosinessEntities.GetContext().User.Where(c => c.Role_ID == secID).ToList();
        }

        private void RefreshCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажать на кнопку обновить
        {
            e.CanExecute = isDirty;
        }

        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Обновление данных
        {
            RoleSearch.Text = "";
            DataGridUser.ItemsSource = null;
            DataGridUser.ItemsSource = CosinessEntities.GetContext().User.ToList();
            isDirty = false;
            BorderFind.Visibility = Visibility.Visible;
        }

        private void RoleSearch_SelectionChanged(object sender, SelectionChangedEventArgs e) //При изменении поиска - включается кнопка поиска
        {
            RoleSearchButton.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //Возвращение в меню персонала
        {
            PersonalMenu window = new PersonalMenu();
            window.Show();
            this.Close();
        }
    }
}