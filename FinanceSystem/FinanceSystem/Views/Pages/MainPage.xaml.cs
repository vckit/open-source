using FinanceSystem.Views.Pages.FinanceOperationPages;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FinanceSystem.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoadDataStudent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StudentPages.DataStudents());
        }

        private void DataOperation_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DataOperationView());
        }
    }
}
