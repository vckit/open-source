using FinanceSystem.Context;
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

namespace FinanceSystem.Views.Pages.FinanceOperationPages
{
    /// <summary>
    /// Логика взаимодействия для HistoryOperationView.xaml
    /// </summary>
    public partial class HistoryOperationView : Page
    {
        public HistoryOperationView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StudentData.ItemsSource = dbContext.db.Transaction.ToList();
        }

        private void DateOperation_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentData.ItemsSource = dbContext.db.Transaction.Where(item => item.DateTransaction == DateOperation.SelectedDate).ToList();
        }
    }
}
