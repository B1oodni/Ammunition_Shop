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
using System.Windows.Shapes;

namespace Ammunition_Shop.Windows
{
    /// <summary>
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public static string CurrentUserEmail { get; private set; }

        public Autorization()
        {
            InitializeComponent();
        }

        private void buttonAutorization_Click(object sender, RoutedEventArgs e)
        {
            string email = textBoxEmailAu.Text.ToLower().Trim();
            string pass = passwordBox.Password.Trim();

            if (pass.Length < 8)
            {
                passwordBox.ToolTip = "Пароль неверный!";
                passwordBox.Background = Brushes.DarkRed;
            }

            else if (email.Length < 5)
            {
                textBoxEmailAu.ToolTip = "Почта не найдена!";
                textBoxEmailAu.Background = Brushes.DarkRed;
            }

            else
            {
                textBoxEmailAu.ToolTip = "";
                textBoxEmailAu.Background = Brushes.Transparent;
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;

                User authUser = null;
                using (Classes.AppContext context = new Classes.AppContext())
                {
                    authUser = context.Users.Where(b => b.Email == email && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Вы успешно вошли");
                    MainWindow mainw = new MainWindow();
                    mainw.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
        }
    }
}
