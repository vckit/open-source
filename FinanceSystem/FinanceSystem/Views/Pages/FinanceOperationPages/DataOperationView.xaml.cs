using FinanceSystem.Context;
using FinanceSystem.Model;
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
    /// Логика взаимодействия для DataOperationView.xaml
    /// </summary>
    public partial class DataOperationView : Page
    {
        public DataOperationView()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StudentData.ItemsSource = dbContext.db.Student.ToList();
        }

        private void ButtonSendScholarship_Click(object sender, RoutedEventArgs e)
        {
            var students = dbContext.db.Student.ToList();
            var types = dbContext.db.Type.ToList();
            Transaction transaction = new Transaction();
            foreach (var student in students)
            {
                transaction.DateTransaction = DateTime.Now;
                transaction.IDStudent = student.ID;
                transaction.Scholarship = student.Type.Scholarship;
                dbContext.db.Transaction.Add(transaction);
                dbContext.db.SaveChanges();
            }
            MessageBox.Show("Стипендии успешно распределены", "Операция прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ButtonHistory_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HistoryOperationView());
        }
    }
}
