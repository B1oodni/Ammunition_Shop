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
using System.Windows.Threading;
using System.IO;

namespace Ammunition_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Classes.AppContext db;

        private DispatcherTimer timer;
        private List<string> messages;
        private int currentIndex;

        public MainWindow()
        {
            InitializeComponent();
            db = new Classes.AppContext();

            messages = new List<string>
            {
                "У нас самые лучшие товары!",
                "С нами безопасность, гарантия, точность!",
                "Не проходите мимо!",
                "Только по одному экземпляру."
                // Добавьте здесь нужные сообщения
            };

            // Инициализация таймера
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(10);
            timer.Tick += Timer_Tick;

            cartWindow = new Cart();
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Создание экземпляра контекста базы данных
            db = new Classes.AppContext();

            // Загрузка информации из базы данных и установка значений в текстовые поля
            LoadProductInfo();
            StartTimer();
        }

        private void StartTimer()
        {
            timer.Start();
        }

        private void StopTimer()
        {
            timer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Обновление текста в TextBox
            if (currentIndex < messages.Count)
            {
                messageTextBox.Text = messages[currentIndex];
                messageTextBox.IsReadOnly = true;
                currentIndex++;
            }
            else
            {
                StopTimer(); // Остановка таймера, когда все сообщения пройдены
            }
        }

        #region Товары из каталога
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
        #endregion

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
            Cart cart = new Cart();
            cart.Show();
        }

        #region К определённому элементу
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

        private void KatRS_Click(object sender, RoutedEventArgs e)
        {
            buttonBuyRyukzakSumka.Focus();
        }

        private void KatOnas_Click(object sender, RoutedEventArgs e)
        {
            bONAS.Focus();
        }

        private void KatGdeNahod_Click(object sender, RoutedEventArgs e)
        {
            bGdeNahod.Focus();

        }

        private Cart cartWindow;

        private void KatKontakti_Click(object sender, RoutedEventArgs e)
        {
            
        }
        #endregion

        private const string DataFilePath = "data.txt";


        private void buttonBuyKyrtky_Click(object sender, RoutedEventArgs e)
        {
            //string data = textBoxTitle.Text;
            string text = textBoxTitle.Text;
            string price = textBoxPrice.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");



            // Открытие второго окна
            Cart cart = new Cart();
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Удалить файл, если он существует
            if (File.Exists(DataFilePath))
            {
                File.Delete(DataFilePath);
            }
        }

        private void buttonBuyKyrtky_Copy_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy.Text;
            string price = textBoxPrice_Copy.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

            Cart cart = new Cart();
        }

        private void buttonBuyKyrtky_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy1.Text;
            string price = textBoxPrice_Copy1.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyKyrtky_Copy2_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy2.Text;
            string price = textBoxPrice_Copy2.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyBotinki_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy3.Text;
            string price = textBoxPrice_Copy3.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyBotinki_Copy_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy4.Text;
            string price = textBoxPrice_Copy4.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyBotinki_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy5.Text;
            string price = textBoxPrice_Copy5.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyBotinki_Copy2_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy6.Text;
            string price = textBoxPrice_Copy6.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyRyukzakSumka_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy7.Text;
            string price = textBoxPrice_Copy7.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyRyukzakSumka_Copy_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy8.Text;
            string price = textBoxPrice_Copy8.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyRyukzakSumka_Copy1_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy9.Text;
            string price = textBoxPrice_Copy9.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }

        private void buttonBuyRyukzakSumka_Copy2_Click(object sender, RoutedEventArgs e)
        {
            string text = textBoxTitle_Copy10.Text;
            string price = textBoxPrice_Copy10.Text;

            File.AppendAllText(DataFilePath, "-----------------");
            File.AppendAllText(DataFilePath, $"\n{text}, {price}\n");

        }
    }
}
