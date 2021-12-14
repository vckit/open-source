using JewerlyStore.Classes;
using JewerlyStore.DB;
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

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для CheckoutPage.xaml
    /// </summary>
    public partial class CheckoutPage : Page
    {
        public CheckoutPage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void txbPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789+".IndexOf(e.Text) < 0;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Client client = new Client();
                client.FirstName = txbFirstName.Text;
                client.LastName = txbLastName.Text;
                client.SecondName = txbSecondName.Text;
                client.Phone = txbPhone.Text;
                ConnectClass.db.Client.Add(client);
                ConnectClass.db.SaveChanges();
                MessageBox.Show("Клиент добавлен.", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new PaymentPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentPage());
        }
    }
}
