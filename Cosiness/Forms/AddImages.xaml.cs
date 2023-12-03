using Cosiness.Commands;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Cosiness.DataBase;

namespace Cosiness
{
    /// <summary>
    /// Логика взаимодействия для AddImages.xaml
    /// </summary>
    public partial class AddImages : Window
    {
        public AddImages()  //Определяем данные
        {
            InitializeComponent();
            _ = new ImageClass();
            CosinessEntities image = new CosinessEntities();
            DataGridImages.ItemsSource = image.Images.ToList();
        }

        private void Browse_Click(object sender, RoutedEventArgs e) //Функционал файлового браузера windows
        {
            _ = new ImageClass();
            _ = new CosinessEntities();
            OpenFileDialog OpenFileObj = new OpenFileDialog();
            OpenFileObj.ShowDialog();
            Path.Text = OpenFileObj.FileName;
            if (Path.Text == "")
            {
                MessageBox.Show("Не выбран путь");
            }
            else
            {
                try
                {
                    ImageSource imgsource = new BitmapImage(new Uri(Path.Text));
                    Preview.Source = imgsource;
                }
                catch 
                {
                    MessageBox.Show("Не верный формат файла");
                }

            }

        }

        private void Upload_Click(object sender, RoutedEventArgs e) //Функционал загрузки данных в БД
        {
            ImageClass imgs = new ImageClass();
            CosinessEntities image = new CosinessEntities();
            if (Path.Text == "")
            {
                MessageBox.Show("Не выбран файл");
                return;
            }
            Images img = new Images()
            {
                ImagePath = Path.Text,
                Bytes = File.ReadAllBytes(Path.Text),
            };

            var NomImage = CosinessEntities.GetContext().Images.Max(d => d.Image_ID);
            if (NomImage == 0)
            {
                NomImage = 1;
            }
            else
            {
                NomImage++;
            }
            img.Image_ID = NomImage;
            CosinessEntities.GetContext().Images.Add(img);
            try
            {
                CosinessEntities.GetContext().SaveChanges();
                DataGridImages.ItemsSource = null;
                DataGridImages.ItemsSource = CosinessEntities.GetContext().Images.ToList();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            DataGridImages.ItemsSource = image.Images.ToList();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) //возвращение на предыдущую страницу
        {
            PersonalCatalog window = new PersonalCatalog();
            window.Show();
            this.Close();
        }
    }
}
