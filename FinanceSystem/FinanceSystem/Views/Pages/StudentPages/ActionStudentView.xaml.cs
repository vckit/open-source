using FinanceSystem.Context;
using FinanceSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace FinanceSystem.Views.Pages.StudentPages
{
    /// <summary>
    /// Логика взаимодействия для ActionStudentView.xaml
    /// </summary>
    public partial class ActionStudentView : Page
    {
        public Student Student { get; set; }
        public Requisites Requisites { get; set; }
        public List<Group> Groups { get; set; }
        public List<Departments> Departments { get; set; }
        public List<Model.Type> Type { get; set; }

        public ActionStudentView(Student student, Requisites requisites)
        {
            InitializeComponent();
            Groups = dbContext.db.Group.ToList();
            Departments = dbContext.db.Departments.ToList();
            Type = dbContext.db.Type.ToList();

            Student = student;
            Requisites = requisites;
            this.DataContext = this;
        }

        private void ButtonSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Student.ID == 0 && Requisites.ID == 0)
                {
                    dbContext.db.Requisites.Add(Requisites);
                    dbContext.db.Student.Add(Student);
                }
                dbContext.db.SaveChanges();
                MessageBox.Show("Данные успешно сохранены в базу данных", "Сохрнанение прошло успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
