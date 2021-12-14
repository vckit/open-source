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
using hpapp.Context;
using hpapp.Model;

namespace hpapp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPageEmployee.xaml
    /// </summary>
    public partial class ActionPageEmployee : Page
    {
        public Employee Employee { get; set; }
        public List<Polyclinic> Polyclinics { get; set; }
        public ActionPageEmployee(Employee employee)
        {
            InitializeComponent();
            Polyclinics = AppData.db.Polyclinic.ToList();
            Employee = employee;
            this.DataContext = this;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(Employee.ID == 0)
            {
                AppData.db.Employee.Add(Employee);
            }
            AppData.db.SaveChanges();

            MessageBox.Show("Данные были успешно зафиксированы в базе данных!", "Операция прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
