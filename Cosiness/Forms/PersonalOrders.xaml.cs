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
    /// Логика взаимодействия для PersonalOrders.xaml
    /// </summary>
    public partial class PersonalOrders : Window
    {
        public PersonalOrders() //Получение данных
        {
            InitializeComponent();
            orderGrid.ItemsSource = CosinessEntities.GetContext().Order.ToList();
            Точка.ItemsSource = CosinessEntities.GetContext().Pick_up_Point.ToList();
            Статус.ItemsSource = CosinessEntities.GetContext().Order_status.ToList();
            ordersGridProd.ItemsSource = CosinessEntities.GetContext().Order_List.ToList();
            Products.ItemsSource = CosinessEntities.GetContext().Product.ToList();
        }
        private bool isDirty = true;
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность удаления
        {
            e.CanExecute = isDirty;
        }
        private void DeleteCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Удаление файлов для двух разных датагридов 
        {
            if (ordersGridProd.Visibility == Visibility.Hidden)
            {

                var RemovingPers1 = orderGrid.SelectedItems.Cast<Order>().ToList();
                if (MessageBox.Show($"Удалить {RemovingPers1.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        CosinessEntities.GetContext().Order.RemoveRange(RemovingPers1);
                        CosinessEntities.GetContext().SaveChanges();
                        MessageBox.Show("Удалено");
                        orderGrid.ItemsSource = CosinessEntities.GetContext().Order.ToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
                else if (orderGrid.Visibility == Visibility.Hidden)
                {
                    var RemovingPers = ordersGridProd.SelectedItems.Cast<Order_List>().ToList();
                    if (MessageBox.Show($"Удалить {RemovingPers.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        try
                        {
                            CosinessEntities.GetContext().Order_List.RemoveRange(RemovingPers);
                            CosinessEntities.GetContext().SaveChanges();
                            MessageBox.Show("Удалено");
                            ordersGridProd.ItemsSource = CosinessEntities.GetContext().Order_List.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString());
                        }
                    }
                }
                isDirty = false;
            }
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность редактирования
        {
            e.CanExecute = isDirty;
        }
        private void EditCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Редактирование для двух разных датагридов
        {
            if (ordersGridProd.Visibility == Visibility.Hidden)
            {
                orderGrid.IsReadOnly = false;
                orderGrid.BeginEdit();
                isDirty = false;
            }
            else if (orderGrid.Visibility == Visibility.Hidden)
            {
                ordersGridProd.IsReadOnly = false;
                ordersGridProd.BeginEdit();
                isDirty = false;
            }
        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Сохранение
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
            ordersGridProd.IsReadOnly = true;
            orderGrid.IsReadOnly = true;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность сохранения
        {
            e.CanExecute = !isDirty;
        }
        private void UndoCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Возврат последнего действия для двух разных датагридов
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
            if (ordersGridProd.Visibility == Visibility.Hidden)
            {
                orderGrid.ItemsSource = null;
                orderGrid.ItemsSource = CosinessEntities.GetContext().Order.ToList();
                MessageBox.Show("Отмена действия");
                isDirty = true;
                orderGrid.IsReadOnly = true;
            }
            else if (orderGrid.Visibility == Visibility.Hidden)
            {
                ordersGridProd.ItemsSource = null;
                ordersGridProd.ItemsSource = CosinessEntities.GetContext().Order_List.ToList();
                MessageBox.Show("Отмена действия");
                isDirty = true;
                ordersGridProd.IsReadOnly = true;
            }

        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность возврата
        {
            e.CanExecute = !isDirty;
        }
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Создание нового заказа или листа товаров
        {
            if (ordersGridProd.Visibility == Visibility.Hidden)
            {
                orderGrid.IsReadOnly = false;
                Order order = new Order()
                {
                    Order_Date = DateTime.Now,
                    Name = "Введите имя",
                    Surname = "Введите фамилию",
                    Patronymic = "Введите отчество",
                    Status_ID = 1,
                    Point_ID = 1,
                    User_ID = null,
                };

                int Nomorder = 0;
                if (Nomorder == 0)
                {
                    Nomorder = 1;
                }

                else
                {
                    Nomorder = CosinessEntities.GetContext().Order.Max(d => d.Order_ID);
                    Nomorder++;
                }

                order.Order_ID = Nomorder;
                CosinessEntities.GetContext().Order.Add(order);
                try
                {
                    CosinessEntities.GetContext().SaveChanges();
                    orderGrid.ItemsSource = null;
                    orderGrid.ItemsSource = CosinessEntities.GetContext().Order.ToList();
                    MessageBox.Show("Данные готовы к добавлению");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (orderGrid.Visibility == Visibility.Hidden) 
            {
                ordersGridProd.IsReadOnly = false;
                Order_List order_list = new Order_List()
                {
                    Order_ID = CosinessEntities.GetContext().Order_List.Max(d => d.Order_ID),
                    Product_ID = 1,
                };

                int Nomorder = 0;
                if (Nomorder == 0)
                {
                    Nomorder = 1;
                }

                else
                {
                    Nomorder = CosinessEntities.GetContext().Order_List.Max(d => d.List_ID);
                    Nomorder++;
                }

                order_list.List_ID = Nomorder;
                CosinessEntities.GetContext().Order_List.Add(order_list);
                try
                {
                    CosinessEntities.GetContext().SaveChanges();
                    ordersGridProd.ItemsSource = null;
                    ordersGridProd.ItemsSource = CosinessEntities.GetContext().Order_List.ToList();
                    MessageBox.Show("Данные готовы к добавлению");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            isDirty = false;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность создания новых строк
        {
            e.CanExecute = isDirty;
        }

        private void RefreshCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e) //Возможность обновления
        {
            e.CanExecute = isDirty;
        }

        private void RefreshCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e) //Обновление данных
        {
            orderGrid.ItemsSource = null;
            orderGrid.ItemsSource = CosinessEntities.GetContext().Order.ToList();
            ordersGridProd.ItemsSource = null;
            ordersGridProd.ItemsSource = CosinessEntities.GetContext().Order_List.ToList();
            isDirty = false;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //Переход в меню персонала
        {
            PersonalMenu window = new PersonalMenu();
            window.Show();
            this.Close();
        }

        private void ToOrders_Click(object sender, RoutedEventArgs e) //Переход в датагрид заказов
        {
            orderGrid.Visibility = Visibility.Visible;
            ordersGridProd.Visibility = Visibility.Hidden;

        }

        private void ToOrderProd_Click(object sender, RoutedEventArgs e) //Переход в датагрид листа продуктов
        {
            ordersGridProd.Visibility = Visibility.Visible;
            orderGrid.Visibility = Visibility.Hidden;
        }
    }
}