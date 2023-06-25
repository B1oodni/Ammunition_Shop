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
    /// Логика взаимодействия для Admins.xaml
    /// </summary>
    public partial class Admins : Window
    {
        public Admins()
        {
            InitializeComponent();
        }

        private void buttonAutorization_Click(object sender, RoutedEventArgs e)
        {
            string loginAdmin = textBoxLoginAu.Text.Trim();
            string passAdmin = passwordBox.Password.Trim();

            if (passAdmin.Length < 8)
            {
                passwordBox.ToolTip = "Пароль неверный!";
                passwordBox.Background = Brushes.DarkRed;
            }

            else if (loginAdmin.Length < 5)
            {
                textBoxLoginAu.ToolTip = "Логин неверный!";
                textBoxLoginAu.Background = Brushes.DarkRed;
            }

            else
            {
                textBoxLoginAu.ToolTip = "";
                textBoxLoginAu.Background = Brushes.Transparent;
                passwordBox.ToolTip = "";
                passwordBox.Background = Brushes.Transparent;

                Administrator authUser = null;
                using (Classes.AppContext context = new Classes.AppContext())
                {
                    authUser = context.Administrators.Where(b => b.LoginAdmin == loginAdmin && b.PassAdmin == passAdmin).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MessageBox.Show("Вы успешно вошли");
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Администратор не найден!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.Show();
        }
    }
}
