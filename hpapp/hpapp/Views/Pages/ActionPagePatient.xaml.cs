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
    /// Логика взаимодействия для ActionPagePatient.xaml
    /// </summary>
    public partial class ActionPagePatient : Page
    {
        public Patient Patient { get; set; }
        public List<District> Districts { get; set; }
        public List<Polyclinic> Polyclinics { get; set; }
        public ActionPagePatient(Patient patient)
        {
            InitializeComponent();
            Districts = AppData.db.District.ToList();
            Polyclinics = AppData.db.Polyclinic.ToList();
            Patient = patient;
            this.DataContext = this;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(Patient.ID == 0)
            {
                AppData.db.Patient.Add(Patient);
            }
            AppData.db.SaveChanges();
            MessageBox.Show("Данные были успешно сохранены!", "Операция прошла успешно.", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
