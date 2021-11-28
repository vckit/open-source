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
using FinanceSystem.Model;

namespace FinanceSystem.Views.Pages.StudentPages
{
    /// <summary>
    /// Логика взаимодействия для DataStudents.xaml
    /// </summary>
    public partial class DataStudents : Page
    {
        public DataStudents()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StudentData.ItemsSource = dbContext.db.Student.ToList();
        }

        private void ButtonCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ActionStudentView(new Student(), new Requisites()));
        }

        private void ButtonEditStudent_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentData.SelectedItem;
            var selectedRequisites = dbContext.db.Requisites.FirstOrDefault(item => item.ID == selectedStudent.IDRequisites);
            if (selectedStudent != null && selectedRequisites != null)
            {
                NavigationService.Navigate(new ActionStudentView(selectedStudent, selectedRequisites));
            }
        }

        private void ButtonRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = (Student)StudentData.SelectedItem;
            if (selectedStudent != null)
            {
                if (MessageBox.Show("Вы дейтствительно хотите удалить данные?", "Данные будут потеряны без возможности восстановить.", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    dbContext.db.Student.Remove(selectedStudent);
                    dbContext.db.SaveChanges();
                    Page_Loaded(null, null);
                    MessageBox.Show("Данные успешно удалены из базы данных", "Данные удалены." , MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void TypeStudentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TypeStudentComboBox.SelectedItem.ToString() == "Все")
            {
                StudentData.ItemsSource = dbContext.db.Student.ToList();
            }
            else if (TypeStudentComboBox.SelectedItem.ToString() == "Отличник")
            {
                StudentData.ItemsSource = dbContext.db.Student.Where(item => item.Type.Title == TypeStudentComboBox.SelectedItem.ToString()).ToList();
            }
            else if (TypeStudentComboBox.SelectedItem.ToString() == "Хорошист")
            {
                StudentData.ItemsSource = dbContext.db.Student.Where(item => item.Type.Title == TypeStudentComboBox.SelectedItem.ToString()).ToList();
            }
            else if (TypeStudentComboBox.SelectedItem.ToString() == "Троечник")
            {
                StudentData.ItemsSource = dbContext.db.Student.Where(item => item.Type.Title == TypeStudentComboBox.SelectedItem.ToString()).ToList();
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            StudentData.ItemsSource = dbContext.db.Student.Where(item => item.FirstName.Contains(SearchTextBox.Text) || item.LastName.Contains(SearchTextBox.Text) || item.Patronymic.Contains(SearchTextBox.Text) ||
            item.Phone.Contains(SearchTextBox.Text)).ToList();
        }

    }
}
