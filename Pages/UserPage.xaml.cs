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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int ClassId;
                switch (ClassBox.SelectedIndex)
                {
                    case 1:
                        ClassId = 1;
                        break;
                    case 2:
                        ClassId = 5;
                        break;
                    case 3:
                        ClassId = 3;
                        break;
                    default:
                        ClassId = 1;
                        break;
                }
                Заказы newOrder = new Заказы { Куда = ToBox.Text, Откуда = FromBox.Text, АйдиКласса = ClassId, АйдиСотрудника = 6, АйдиАвтомобиля = 6 };
                Core.DB.Заказы.Add(newOrder);
                Core.DB.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка!", "杯米尹安圬早存煨幻末", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Core.mainWindow.MainFrame.Navigate(new SuccessPage());
        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            Core.mainWindow.MainFrame.Navigate(new LoginPage());
        }
    }
}
