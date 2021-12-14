using JewerlyStore.View.Pages.FunctionsWithData;
using JewerlyStore.View.Windows;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace JewerlyStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CheckoutPage());
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainViewPage());
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnHistory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryPage());
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Уверены.", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                NavigationService.Navigate(new AutorizationPage());
        }
    }
}
