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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FinanceSystem.Context;
using FinanceSystem.Model;

namespace FinanceSystem.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Page
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var signInQuery = dbContext.db.SignIn.Where(item => item.Username == UsernameTextBox.Text && item.Password == PasswordPasswordBox.Password);
                if(signInQuery != null)
                {
                    NavigationService.Navigate(new MainPage());
                }
                else
                {
                    MessageBox.Show("НЕ верные данные, пожалуйста повторите попытку.", "Пользователь не найден", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationApp());
        }
    }
}
