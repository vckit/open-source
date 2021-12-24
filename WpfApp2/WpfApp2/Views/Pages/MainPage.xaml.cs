using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using WpfApp2.Context;
using WpfApp2.Model;

namespace WpfApp2.Views.Pages
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

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Student.ToList();
        }
        // Редактирование
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Student)DataSource.SelectedItem;
            if(selectedItem != null)
            {
                NavigationService.Navigate(new ActionPageView(selectedItem));
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Student)DataSource.SelectedItem;
            if (selectedItem != null)
            {
                AppData.db.Student.Remove(selectedItem);
                AppData.db.SaveChanges();
                MessageBox.Show("Удаление прошло успешно!", "Данные были успешно удалены", MessageBoxButton.OK, MessageBoxImage.Information);
                Page_Loaded(null, null);
            }
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void AddClick_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPageView(new Model.Student()));
        }
    }
}
