using Ammunition_Shop.Windows;
using Ammunition_Shop.Classes;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ammunition_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Classes.AppContext db;

        public MainWindow()
        {
            InitializeComponent();
            db = new Classes.AppContext();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Создание экземпляра контекста базы данных
            db = new Classes.AppContext();

            // Загрузка информации из базы данных и установка значений в текстовые поля
            LoadProductInfo();
        }

        private void LoadProductInfo()
        {
            // Выполнение запроса к базе данных для получения продукта с ID_Product = 1
            Product product = db.Products.FirstOrDefault(p => p.ID_Product == 1);

            if (product != null)
            {
                string formattedPrice = string.Format("{0:C}", product.Price);
                // Установка значений в текстовые поля
                textBoxPrice.Text = formattedPrice;
                textBoxTitle.Text = product.Title;

                textBoxPrice.IsReadOnly = true;
                textBoxTitle.IsReadOnly = true;
            }
        }   

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            Registration regw = new Registration();
            regw.Show();
        }

        private void VhodButton_Click(object sender, RoutedEventArgs e)
        {
            Autorization autw = new Autorization();
            autw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FixedButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationButton.Focus();
        }
    }
}
