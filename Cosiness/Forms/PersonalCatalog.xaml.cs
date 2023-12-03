using System;
using System.Data.Entity;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Cosiness.DataBase;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для PersonalCatalog.xaml
    /// </summary>
    public partial class PersonalCatalog : Window
    {
        public PersonalCatalog() //Получаем данные
        {
            InitializeComponent();
            DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.ToList();
            СекторChange.ItemsSource = CosinessEntities.GetContext().Storage.ToList();
            StorageSearch.ItemsSource = CosinessEntities.GetContext().Storage.ToList();
            ImagesChange.ItemsSource = CosinessEntities.GetContext().Images.ToList();
        }
        private bool isDirty = true;
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажатия кнопки удаления
        {
            e.CanExecute = isDirty;
        }
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Удаление файлов
        {
            var RemovingPers = DataGridProduct.SelectedItems.Cast<Product>().ToList();

            if (MessageBox.Show($"Удалить {RemovingPers.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    CosinessEntities.GetContext().Product.RemoveRange(RemovingPers);  //Выбираем определенное количество элементов и удаляем их, сохраняем бд, обновляем таблицу.
                    CosinessEntities.GetContext().SaveChanges();
                    MessageBox.Show("Удалено");
                    DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            isDirty = false;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажатия кнопки изменения
        {
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Изменение файлов через метод BegitEdit()
        {
            DataGridProduct.IsReadOnly = false;
            DataGridProduct.BeginEdit();
            isDirty = false;
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Сохранение информации
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
            DataGridProduct.IsReadOnly = true;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажатия кнопки сохранения
        {
            e.CanExecute = !isDirty;
        }
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Возврат последнего действия
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
            DataGridProduct.ItemsSource = null;
            DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.ToList();
            MessageBox.Show("Отмена действия");
            isDirty = true;
            DataGridProduct.IsReadOnly = true;
        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажатия на отмену
        {
            e.CanExecute = !isDirty;
        }
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Создание новой строки в таблице
        {

            DataGridProduct.IsReadOnly = false;
            Product Prod = new Product()
            {
                Name = "",
                Price = 0,
                Storage_ID = 1,
            };

            int NomProduct = CosinessEntities.GetContext().Product.Max(d => d.Product_ID);
            if (NomProduct == 0)
            {
                NomProduct = 1;
            }
            else
            {
                NomProduct++;
            }

            Prod.Product_ID = NomProduct;
            CosinessEntities.GetContext().Product.Add(Prod);
            try
            {
                CosinessEntities.GetContext().SaveChanges();
                DataGridProduct.ItemsSource = null;
                DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.ToList();
                MessageBox.Show("Данные готовы к добавлению");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            isDirty = false;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность нажатия на кнопку создания
        {
            e.CanExecute = isDirty;
        }

        private void NameSearchButton_Click(object sender, RoutedEventArgs e) //Кнопка поиска названия товара по нажатию клавиши
        {
            StorageSearch.Text = "";
            string Name = NameSearch.Text;
            var check = CosinessEntities.GetContext().Product.Where(c => c.Name.Contains(Name)).ToList();
            if (check.FirstOrDefault() == null)
            {
                MessageBox.Show("Название неправильно записано или не введено", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                DataGridProduct.ItemsSource = null;
                DataGridProduct.ItemsSource = (System.Collections.IEnumerable)check;
            }
        }
        private void StorageSearchButton_Click(object sender, RoutedEventArgs e) //Поиск по складам
        {
            string SecName = StorageSearch.Text;
            Storage secIDQuery = (Storage)CosinessEntities.GetContext().Storage.Where(c => c.Storage_Name.Contains(SecName)).FirstOrDefault();
            int secID = secIDQuery.Storage_ID;
            DataGridProduct.ItemsSource = null;
            DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.Where(c => c.Storage_ID == secID).ToList();
        }

        private void RefreshCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)  //Возможность нажатия на кнопку обновления
        {
            e.CanExecute = isDirty;
        }

        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Обновление всех данных
        {
            StorageSearch.Text = "";
            NameSearch.Text = "";
            DataGridProduct.ItemsSource = null;
            DataGridProduct.ItemsSource = CosinessEntities.GetContext().Product.ToList();
            isDirty = false;
            BorderFind.Visibility = Visibility.Visible;
        }

        private void NameSearch_TextChanged(object sender, TextChangedEventArgs e) //При изменении текста в поиске названия
        {
            NameSearchButton.IsEnabled = true;
            НаличиеСкладSearchButton.IsEnabled = false;
        }

        private void StorageSearch_SelectionChanged(object sender, SelectionChangedEventArgs e) //При изменение выбора в поиске категории
        {
            NameSearchButton.IsEnabled = false;
            НаличиеСкладSearchButton.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //Возврат в меню сотрудника
        {
            PersonalMenu window = new PersonalMenu();
            window.Show();
            this.Close();
        }

        private void ToImages_Click(object sender, RoutedEventArgs e) //Открытие окна добавления картинок
        {
            AddImages window = new AddImages();
            window.Show();
        }
    }
}