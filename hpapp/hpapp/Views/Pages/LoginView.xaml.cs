using hpapp.Context;
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

namespace hpapp.Views.Pages
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var queryAuth = AppData.db.SignIn.FirstOrDefault(item => item.Username == txbUsername.Text && item.Password == psbPassword.Password);
            if(queryAuth != null)
            {

                NavigationService.Navigate(new MainPage(queryAuth.Employee.GetFullName));
            }
            else
            {
                MessageBox.Show("Пользователь не найден, проверьте пароль и логин ещё раз.", "Авторизация провалена", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SignUpView());
        }
    }
}
