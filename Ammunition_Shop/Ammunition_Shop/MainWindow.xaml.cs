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
            Product kyrtka = db.Products.FirstOrDefault(p => p.ID_Product == 1);

            if (kyrtka != null)
            {
                string formattedPrice = string.Format("{0:C}", kyrtka.Price);
                // Установка значений в текстовые поля
                textBoxPrice.Text = formattedPrice;
                textBoxTitle.Text = kyrtka.Title;

                textBoxPrice.IsReadOnly = true;
                textBoxTitle.IsReadOnly = true;
            }

            Product kyrtka2 = db.Products.FirstOrDefault(p => p.ID_Product == 2);

            if (kyrtka2 != null)
            {
                string formattedPrice = string.Format("{0:C}", kyrtka2.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy.Text = formattedPrice;
                textBoxTitle_Copy.Text = kyrtka2.Title;

                textBoxPrice_Copy.IsReadOnly = true;
                textBoxTitle_Copy.IsReadOnly = true;
            }

            Product kyrtka3 = db.Products.FirstOrDefault(p => p.ID_Product == 3);

            if (kyrtka3 != null)
            {
                string formattedPrice = string.Format("{0:C}", kyrtka3.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy1.Text = formattedPrice;
                textBoxTitle_Copy1.Text = kyrtka3.Title;

                textBoxPrice_Copy1.IsReadOnly = true;
                textBoxTitle_Copy1.IsReadOnly = true;
            }

            Product kyrtka4 = db.Products.FirstOrDefault(p => p.ID_Product == 4);

            if (kyrtka4 != null)
            {
                string formattedPrice = string.Format("{0:C}", kyrtka4.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy2.Text = formattedPrice;
                textBoxTitle_Copy2.Text = kyrtka4.Title;

                textBoxPrice_Copy2.IsReadOnly = true;
                textBoxTitle_Copy2.IsReadOnly = true;
            }

            Product boti = db.Products.FirstOrDefault(p => p.ID_Product == 6);

            if (boti != null)
            {
                string formattedPrice = string.Format("{0:C}", boti.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy3.Text = formattedPrice;
                textBoxTitle_Copy3.Text = boti.Title;

                textBoxPrice_Copy3.IsReadOnly = true;
                textBoxTitle_Copy3.IsReadOnly = true;
            }

            Product boti2 = db.Products.FirstOrDefault(p => p.ID_Product == 7);

            if (boti2 != null)
            {
                string formattedPrice = string.Format("{0:C}", boti2.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy4.Text = formattedPrice;
                textBoxTitle_Copy4.Text = boti2.Title;

                textBoxPrice_Copy4.IsReadOnly = true;
                textBoxTitle_Copy4.IsReadOnly = true;
            }

            Product boti3 = db.Products.FirstOrDefault(p => p.ID_Product == 8);

            if (boti3 != null)
            {
                string formattedPrice = string.Format("{0:C}", boti3.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy5.Text = formattedPrice;
                textBoxTitle_Copy5.Text = boti3.Title;

                textBoxPrice_Copy5.IsReadOnly = true;
                textBoxTitle_Copy5.IsReadOnly = true;
            }

            Product boti4 = db.Products.FirstOrDefault(p => p.ID_Product == 9);

            if (boti4 != null)
            {
                string formattedPrice = string.Format("{0:C}", boti4.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy6.Text = formattedPrice;
                textBoxTitle_Copy6.Text = boti4.Title;

                textBoxPrice_Copy6.IsReadOnly = true;
                textBoxTitle_Copy6.IsReadOnly = true;
            }

            Product rs = db.Products.FirstOrDefault(p => p.ID_Product == 11);

            if (rs != null)
            {
                string formattedPrice = string.Format("{0:C}", rs.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy7.Text = formattedPrice;
                textBoxTitle_Copy7.Text = rs.Title;

                textBoxPrice_Copy7.IsReadOnly = true;
                textBoxTitle_Copy7.IsReadOnly = true;
            }

            Product rs2 = db.Products.FirstOrDefault(p => p.ID_Product == 12);

            if (rs2 != null)
            {
                string formattedPrice = string.Format("{0:C}", rs2.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy8.Text = formattedPrice;
                textBoxTitle_Copy8.Text = rs2.Title;

                textBoxPrice_Copy8.IsReadOnly = true;
                textBoxTitle_Copy8.IsReadOnly = true;
            }

            Product rs3 = db.Products.FirstOrDefault(p => p.ID_Product == 13);

            if (rs3 != null)
            {
                string formattedPrice = string.Format("{0:C}", rs3.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy9.Text = formattedPrice;
                textBoxTitle_Copy9.Text = rs3.Title;

                textBoxPrice_Copy9.IsReadOnly = true;
                textBoxTitle_Copy9.IsReadOnly = true;
            }

            Product rs4 = db.Products.FirstOrDefault(p => p.ID_Product == 14);

            if (rs4 != null)
            {
                string formattedPrice = string.Format("{0:C}", rs4.Price);
                // Установка значений в текстовые поля
                textBoxPrice_Copy10.Text = formattedPrice;
                textBoxTitle_Copy10.Text = rs4.Title;

                textBoxPrice_Copy10.IsReadOnly = true;
                textBoxTitle_Copy10.IsReadOnly = true;
            }
        }

        private void TextBlockVK_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            // Открываем страницу Вконтакте в браузере
            System.Diagnostics.Process.Start("https://vk.com/maybemaybenot");
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

        private void KatKyrtki_Click(object sender, RoutedEventArgs e)
        {
            buttonBuyKyrtky.Focus();
        }

        private void KatBotinki_Click(object sender, RoutedEventArgs e)
        {
            buttonBuyBotinki.Focus();
        }
    }
}
