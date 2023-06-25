using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using Xceed.Words.NET;

namespace Ammunition_Shop.Windows
{
    /// <summary>
    /// Логика взаимодействия для Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        private const string DataFilePath = "data.txt";

        public Cart()
        {
            InitializeComponent();
            listBox.Items.Clear();
            UpdateListBoxData();

            if (File.Exists(DataFilePath))
            {
                string[] data = File.ReadAllText(DataFilePath).Split(',');
                if (data.Length >= 2)
                {
                    string text = data[0];
                    string price = data[1];

                    listBox.Items.Add($"Название: {text}, Цена: {price}");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal totalSum = 0;
            //GenerateReceipt();
            using (DocX document = DocX.Create("Products.docx"))
            {
                // Чтение данных из файла
                if (File.Exists(DataFilePath))
                {
                    string[] lines = File.ReadAllLines(DataFilePath);
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(',');
                        if (data.Length >= 2)
                        {
                            string text = data[0];
                            string priceStr = data[1];

                            if (decimal.TryParse(priceStr, out decimal price))
                            {   
                                // Добавление информации в документ
                                document.InsertParagraph().AppendLine($"Название: {text}, Цена: {price}");
                                totalSum += price;
                            }
                        }
                    }
                }

                // Добавление параграфа с суммой и сообщением
                document.InsertParagraph().AppendLine($"Всего: {totalSum}");
                document.InsertParagraph().AppendLine("Спасибо за покупку!");

                document.Save();
            }

            MessageBox.Show("Word-документ успешно создан!");

            // Открытие диалогового окна сохранения файла
            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "Word документ (*.docx)|*.docx";
            saveFileDialog.FileName = "Чек.docx";

            if (saveFileDialog.ShowDialog() == true)
            {
                File.Copy("Products.docx", saveFileDialog.FileName, true);
            }
        }

        private void UpdateListBoxData()
        {
            // Очистка ListBox
            listBox.Items.Clear();

            // Чтение данных из файла и добавление в ListBox
            if (File.Exists(DataFilePath))
            {
                string[] lines = File.ReadAllLines(DataFilePath);
                foreach (string line in lines)
                {
                    listBox.Items.Add(line);
                }
            }
        }

        private void GenerateReceipt()
        {
            //// Создание и запись данных в файл
            //string receiptFilePath = "receipt.txt";
            //using (StreamWriter writer = new StreamWriter(receiptFilePath))
            //{
            //    foreach (string item in listBox.Items)
            //    {
            //        writer.WriteLine(item);
            //    }
            //}

            //// Открытие файла с помощью приложения по умолчанию
            //System.Diagnostics.Process.Start(receiptFilePath);

            //// Отображение сообщения с благодарностью
            //MessageBox.Show("Спасибо за покупку!");
        }
    }
}
