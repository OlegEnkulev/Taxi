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

namespace Taxi.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginBTN_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text.Length <= 3)
            {
                MessageBox.Show("Проверьте праильность данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (PasswordBox.Password.Length <= 3)
            {
                MessageBox.Show("Проверьте праильность данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Пользователь user = Core.DB.Пользователь.Where(u => u.Логин == LoginBox.Text && u.Пароль == PasswordBox.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Проверьте праильность данных!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Core.currentUser = user;
            Core.mainWindow.MainFrame.Navigate(new UserPage());
        }
    }
}
