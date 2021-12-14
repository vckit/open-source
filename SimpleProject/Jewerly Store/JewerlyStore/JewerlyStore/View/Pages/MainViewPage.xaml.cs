using JewerlyStore.Classes;
using JewerlyStore.DB;
using JewerlyStore.View.Pages.FunctionsWithData;
using JewerlyStore.View.Windows;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;

namespace JewerlyStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainViewPage.xaml
    /// </summary>
    public partial class MainViewPage : Page
    {
        public MainViewPage()
        {
            InitializeComponent();
        }

        //Инициализация
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Jewelry.ToList();
        }

        //Поиск
        private void searchTxb_TextChanged(object sender, TextChangedEventArgs e)
        {
            listDataView.ItemsSource = ConnectClass.db.Jewelry.Where(item => item.JewName.Contains(searchTxb.Text) || item.Material.Contains(searchTxb.Text) || item.Category.Title.Contains(searchTxb.Text)).ToList();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Добавление
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddPage());
        }

        //Удаление
        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Jewelry removeJewerly = (Jewelry)listDataView.SelectedItem;
                if(removeJewerly != null)
                {
                    if(MessageBox.Show("Вы точно хотите удалить выбранный элемент? Данные будут удалены навсегда!", "Вы уверены?", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        ConnectClass.db.Jewelry.Remove(removeJewerly);
                        ConnectClass.db.SaveChanges();
                        Page_Loaded(null, null);
                    }
                }
                else
                {
                    throw new Exception("Выберите элемент!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Экспорт данных в PDF
        private void pdfBtn_Click(object sender, RoutedEventArgs e)
        {
            ExportWindow window = new ExportWindow();
            window.ShowDialog();
        }
        //Двойное нажатие - изменение
        private void listDataView_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Jewelry editJewelry = (Jewelry)listDataView.SelectedItem;
            if(editJewelry != null)
            {
                NavigationService.Navigate(new EditPage(editJewelry));
            }
        }
    }
}
