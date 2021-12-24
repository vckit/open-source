using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using WpfApp2.Context;
using WpfApp2.Model;

namespace WpfApp2.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ActionPageView.xaml
    /// </summary>
    public partial class ActionPageView : Page
    {
        public Student Student { get; set; }
        public List<Group> Groups { get; set; }
        public List<Gender> Genders { get; set; }
        public List<Status> Statuses { get; set; }
        public ActionPageView(Student student)
        {
            InitializeComponent();
            Student = student;
            Groups = AppData.db.Group.ToList();
            Genders = AppData.db.Gender.ToList();
            Statuses = AppData.db.Status.ToList();
            this.DataContext = this;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Student.ID == 0)
                {
                    AppData.db.Student.Add(Student);
                }
                File.Copy(file.FileName, $"images\\{Path.GetFileName(file.FileName).Trim()}", true);
                Student.GetPhoto = Path.GetFileName(file.FileName).Trim();
                AppData.db.SaveChanges();
                MessageBox.Show("Сохранение данных прошло успешно!", "Данные сохранены", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        OpenFileDialog file = new OpenFileDialog();
        private void SelectPhoto_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
                if (file.ShowDialog() == true)
                {
                    BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                    PhotoImage.Source = imgBitmap;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пожалуйста картинку.", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
