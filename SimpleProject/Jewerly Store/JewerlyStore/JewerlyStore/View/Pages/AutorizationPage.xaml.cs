using JewerlyStore.Classes;
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

namespace JewerlyStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void comeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var currentUser = ConnectClass.db.SignIn.FirstOrDefault(item => item.LogIn == loginTxb.Text && item.Password == passTxb.Password);
                if (currentUser != null)
                {
                    switch (currentUser.RoleID)
                    {
                        case "A":
                            NavigationService.Navigate(new MenuPage());
                            break;
                    }
                }
                else 
                {
                    throw new Exception("Проверьте корректность введенных данных!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnRegistration_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPageView());
        }
    }
}
