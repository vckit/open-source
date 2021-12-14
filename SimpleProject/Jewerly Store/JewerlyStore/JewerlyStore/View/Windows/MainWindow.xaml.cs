using JewerlyStore.View.Pages;
using System;
using System.Windows;
using System.Windows.Threading;

namespace JewerlyStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer LiveTimer = new DispatcherTimer();
            LiveTimer.Interval = TimeSpan.FromSeconds(1);
            LiveTimer.Tick += LiveTimer_Tick;
            LiveTimer.Start();
        }

        private void LiveTimer_Tick(object sender, EventArgs e)
        {
            txbTime.Text = DateTime.Now.ToLongTimeString();
            txbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AutorizationPage());
        }
    }
}
