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
using hpapp.Model;
using System.Windows.Shapes;
using hpapp.Context;

namespace hpapp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage(string fullname)
        {
            InitializeComponent();
            txbFullName.Text = fullname;
        }


        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Employee.ToList();
            DataSource1.ItemsSource = AppData.db.PolyclinicDistrict.ToList();
            dataSource2.ItemsSource = AppData.db.Patient.ToList();
        }

        private void txbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataSource.ItemsSource = AppData.db.Employee.Where(item => item.FirstName.Contains(txbSearch.Text) ||
            item.LastName.Contains(txbSearch.Text) ||
            item.Polyclinic.NumberPolyclinic.Contains(txbSearch.Text) || item.Polyclinic.NSWHE.ToString().Contains(txbSearch.Text) ||
            item.Polyclinic.NSWSSE.ToString().Contains(txbSearch.Text)).ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPageEmployee(new Employee()));
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editEmployee = (Employee)DataSource.SelectedItem;
            if (editEmployee != null)
            {
                NavigationService.Navigate(new ActionPageEmployee(editEmployee));
            }
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var removeEmployee = (Employee)DataSource.SelectedItem;
            if (removeEmployee != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить данные объект?", "Объект будет удален навсегда!", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    AppData.db.Employee.Remove(removeEmployee);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Данные были удалены из базы данных!", "Операция прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btnAddP_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPagePolycklinik(new PolyclinicDistrict(), new Polyclinic()));
        }

        private void btnEditP_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (PolyclinicDistrict)DataSource1.SelectedItem;
            var polyclinicEdit = AppData.db.Polyclinic.FirstOrDefault(item => item.ID == selectedItem.IDPolyclinic);
            if (selectedItem != null)
            {
                NavigationService.Navigate(new ActionPagePolycklinik(selectedItem, polyclinicEdit));
            }
        }

        private void btnRemoveP_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (PolyclinicDistrict)DataSource1.SelectedItem;
            if (selectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить данные объект?", "Объект будет удален навсегда!", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    AppData.db.PolyclinicDistrict.Remove(selectedItem);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Данные были удалены из базы данных!", "Операция прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    Page_Loaded(null, null);
                }
            }
        }

        private void txbSearchPolyclinic_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataSource1.ItemsSource = AppData.db.Polyclinic.Where(item => item.NumberPolyclinic.Contains(txbSearch.Text) ||
            item.AddressPolyclinic.Contains(txbSearch.Text)).ToList();
        }

        private void txbSearchCollection_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnAddC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionPagePatient(new Patient()));
        }

        private void btnEditC_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Patient)dataSource2.SelectedItem;
            if(selectedItem != null)
            {
                NavigationService.Navigate(new ActionPagePatient(selectedItem));
            }
        }

        private void btnRemoveC_Click(object sender, RoutedEventArgs e)
        {
            var selectedItem = (Patient)DataSource1.SelectedItem;
            if (selectedItem != null)
            {
                if (MessageBox.Show("Вы действительно хотите удалить данные объект?", "Объект будет удален навсегда!", MessageBoxButton.OKCancel, MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    AppData.db.Patient.Remove(selectedItem);
                    AppData.db.SaveChanges();
                    MessageBox.Show("Данные были удалены из базы данных!", "Операция прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    Page_Loaded(null, null);
                }
            }
        }

        private void btnReconnection_Click(object sender, RoutedEventArgs e)
        {
            Page_Loaded(null, null);
        }
    }
}
