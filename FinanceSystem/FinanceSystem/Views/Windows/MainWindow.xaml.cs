using FinanceSystem.Views.Pages;
using System;
using System.Windows;

namespace FinanceSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginView());
        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            ButtonBack.Visibility = MainFrame.CanGoBack ? Visibility.Visible : Visibility.Collapsed;
        }
    }
}
