using JewerlyStore.Classes;
using JewerlyStore.DB;
using System;
using System.Linq;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для GetCheckPage.xaml
    /// </summary>
    public partial class GetCheckPage : Page
    {
        private Check Check;
        public GetCheckPage(Check check)
        {
            InitializeComponent();
            this.Check = check;
            txbFioClient.Text = check.Client.FullName;
            txbJewName.Text = check.Jewelry.JewelryCheckGet;
            txbDate.Text = check.Date.ToString();
            txbCommission.Text = check.Commission.ToString();
            txbTotalPrice.Text = check.TotalPrice.ToString();
            txbCount.Text = check.Count.ToString();
        }

        private void btnCheckGet_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(pirntStackpanel, "Check");
            }
            MessageBox.Show("Оформление чека прошло успешно.", "Чек сохранен!", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.Navigate(new MenuPage());
        }
    }
}
