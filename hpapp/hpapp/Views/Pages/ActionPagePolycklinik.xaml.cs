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
using hpapp.Model;
using hpapp.Context;

namespace hpapp.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPagePolycklinik.xaml
    /// </summary>
    public partial class ActionPagePolycklinik : Page
    {
        public Polyclinic Polyclinic { get; set; }
        public PolyclinicDistrict PolyclinicDistrict { get; set; }
        public List<District> Districts { get; set; }
        public ActionPagePolycklinik(PolyclinicDistrict polyclinicDistrict, Polyclinic polyclinic)
        {
            InitializeComponent();
            Districts = AppData.db.District.ToList();
            PolyclinicDistrict = polyclinicDistrict;
            Polyclinic = polyclinic;
            this.DataContext = this;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (PolyclinicDistrict.ID == 0 && Polyclinic.ID == 0)
            {
                AppData.db.Polyclinic.Add(Polyclinic);
                PolyclinicDistrict.IDPolyclinic = Polyclinic.ID;
                AppData.db.PolyclinicDistrict.Add(PolyclinicDistrict);
            }
            AppData.db.SaveChanges();
            MessageBox.Show("Данные были успешно сохранены!", "Операция прошла успешно.", MessageBoxButton.OK, MessageBoxImage.Information);
            NavigationService.GoBack();
        }
    }
}
