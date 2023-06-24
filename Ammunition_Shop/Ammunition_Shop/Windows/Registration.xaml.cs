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
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        private Classes.AppContext db;

        public Registration()
        {
            InitializeComponent();

            db = new Classes.AppContext();
        }

        private void LogTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LogTextBox.Text.Trim();
            string email = EmailTextBox.Text.ToLower().Trim();
            string pass = passwordBox.Password.Trim();

            if (login.Length < 4)
            {
                LogTextBox.ToolTip = "Логин должен быть не менее 4-символов в длинну!";
                LogTextBox.Background = Brushes.DarkRed;
            }
            else
            {
                LogTextBox.ToolTip = "";
                LogTextBox.Background = Brushes.Transparent;
            }

            if (pass.Length < 8)
            {
                passwordBox.ToolTip = "Пароль должен быть не менее 8-символов в длинну!";
                passwordBox.Background = Brushes.DarkRed;
            }

            else
            {
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;
            }

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                EmailTextBox.ToolTip = "Почта введена не корректно!";
                EmailTextBox.Background = Brushes.DarkRed;
            }
            else
            {
                EmailTextBox.ToolTip = "";
                EmailTextBox.Background = Brushes.Transparent;
            }

            if (login.Length >= 4 && pass.Length >= 8 && email.Length >= 5 && email.Contains("@") && email.Contains("."))
            {
                MessageBox.Show("Поля введены верно!");
                User user = new User(login, email, pass);

                db.Users.Add(user);
                db.SaveChanges();

                Autorization aut = new Autorization();
                aut.Show();

                Close();
            }
        }
    }
}
