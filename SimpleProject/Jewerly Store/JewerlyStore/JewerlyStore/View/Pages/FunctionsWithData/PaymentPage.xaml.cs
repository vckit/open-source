using JewerlyStore.Classes;
using JewerlyStore.DB;
using JewerlyStore.View.Pages.PlaceHolder;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для PaymentPage.xaml
    /// </summary>
    public partial class PaymentPage : Page
    {
        private int _balance = 1;
        private int _countJew { get; set; }
        private int _count = 1;
        private float _total { get; set; }
        private float _price { get; set; }
        public PaymentPage()
        {
            InitializeComponent();
            txbCount.Visibility = Visibility.Hidden;
            cmbSelectClient.ItemsSource = ConnectClass.db.Client.ToList();
            cmbSelectClient.DisplayMemberPath = "FullName";
            cmbSelectJewely.ItemsSource = ConnectClass.db.Jewelry.ToList();
            cmbSelectJewely.DisplayMemberPath = "JewelryGet";
        }

        private int _idClient;
        private int _idJewelry;

        private void btnOrderDone_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Check check = new Check();
                Basket basket = new Basket();
                Jewelry jewelry = new Jewelry();
                _idClient = (cmbSelectClient.SelectedItem as Client).ID;
                _idJewelry = (cmbSelectJewely.SelectedItem as Jewelry).ID;
                check.IDClient = _idClient;
                check.IDJewelry = _idJewelry;
                check.Date = DateTime.Now;
                check.TotalPrice = _total;
                check.Count = _count;
                ConnectClass.db.Check.Add(check);
                var selectedCount = ConnectClass.db.Jewelry.FirstOrDefault(item => item.ID == check.IDJewelry);
                selectedCount.Count = _balance;
                basket.IDClient = _idClient;
                basket.IDJewelry = _idJewelry;
                basket.Count = _count;
                basket.TotalPrice = _total;
                ConnectClass.db.Basket.Add(basket);
                ;
                ConnectClass.db.SaveChanges();
                basketRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbSelectJewely_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _countJew = (cmbSelectJewely.SelectedItem as Jewelry).Count;
            _total = (cmbSelectJewely.SelectedItem as Jewelry).Pice;
            _price = _total;
            txbCount.Visibility = Visibility.Visible;
            if (_countJew != 0)
            {
                _count = 1;
                txbCount.Text = _count.ToString();
                txbTotalPrice.Text = _total.ToString();
            }
            else
            {
                MessageBox.Show("Данного товара нет в наличии.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txbCount.Text = "0";
                txbTotalPrice.Text = "0";
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnAddCount_Click(object sender, RoutedEventArgs e)
        {
            txbCount.Visibility = Visibility.Visible;
            if (_countJew != 0)
            {
                if (_countJew == _count)
                {
                    MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else
                {
                    _count++;
                    _balance = _countJew - _count;
                    _total += _price;

                }
                txbTotalPrice.Text = _total.ToString();
                txbCount.Text = _count.ToString();
            }
            else
            {
                MessageBox.Show("Вы первысили количество товара, которое имеется в наличии склада.", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void basketRefresh()
        {
            BasketList.ItemsSource = ConnectClass.db.Basket.Where(item => item.IDClient == _idClient).ToList();
        }
        private void btnRemoveCount_Click(object sender, RoutedEventArgs e)
        {
            if (_count != 0)
            {
                _count--;
                _total -= _price;
            }
            _balance = _countJew + _count;
            txbTotalPrice.Text = _total.ToString();
            txbCount.Text = _count.ToString();
        }
        /// <summary>
        /// ОФормить заказ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetBasket_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var basket = ConnectClass.db.Basket.ToList();
                ConnectClass.db.Basket.RemoveRange(basket);

                ConnectClass.db.SaveChanges();
                PrintDialog print = new PrintDialog();
                if (print.ShowDialog() == true)
                {
                    print.PrintVisual(BasketList, "Check");
                }
                MessageBox.Show("Оформление чека прошло успешно.", "Чек сохранен!", MessageBoxButton.OK, MessageBoxImage.Information);
                basketRefresh();
                NavigationService.Navigate(new MenuPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            var selectedRemove = BasketList.SelectedItem as Basket;
            if(selectedRemove != null)
            {
                ConnectClass.db.Basket.Remove(selectedRemove);
                ConnectClass.db.SaveChanges();
                basketRefresh();
            }
        }
    }
}
