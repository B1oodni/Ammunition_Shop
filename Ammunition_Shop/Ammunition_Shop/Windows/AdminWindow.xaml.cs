using Ammunition_Shop.Classes;
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

namespace Ammunition_Shop.Windows
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Classes.AppContext())
            {
                // Загружаем все элементы из таблицы Users
                var users = context.Users.ToList();

                // Привязываем список пользователей к DataGrid
                dataGrid.ItemsSource = users;
            }
        }

        private void buttonTovar_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Classes.AppContext())
            {
                var products = context.Products.ToList();
                dataGrid.ItemsSource = products;
            }
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Classes.AppContext())
            {
                // Получаем список товаров из DataGrid
                var products = dataGrid.ItemsSource as List<Product>;

                // Если список товаров не равен null, сохраняем изменения
                if (products != null)
                {
                    foreach (var product in products)
                    {
                        // Изменяем состояние сущности на измененное
                        context.Entry(product).State = EntityState.Modified;
                    }

                    // Сохраняем изменения в базе данных
                    context.SaveChanges();

                    MessageBox.Show("Изменения сохранены.");
                }
            }
        }
    }
}
