using JewerlyStore.Classes;
using JewerlyStore.DB;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        public AddPage()
        {
            InitializeComponent();
            //Инициализация данных в комбобокс
            categoryCmb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка добавления
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            Jewelry newJewelry = new Jewelry();
            Category newCategory = new Category();
            Parameters newParameteres = new Parameters();
            try
            {
                //Добавление изобржения
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
                encoder.Save(stream);
                newJewelry.JewImg = stream.ToArray();
                //-------------------------------------------------------------------

                newJewelry.JewName = jewNameTxb.Text;
                newJewelry.Material = materialTxb.Text;
                newJewelry.Pice = Convert.ToInt64(priceTxb.Text);
                newJewelry.ParametersID = newParameteres.ID;
                newJewelry.Count = Convert.ToInt32(txbCount.Text);
                var jewCategory = ConnectClass.db.Category.FirstOrDefault(item => item.Title == categoryCmb.Text);
                newJewelry.CategoryID = jewCategory.ID;

                newParameteres.Height = heightTxb.Text;
                newParameteres.Width = widthTxb.Text;
                newParameteres.Weight = widthTxb.Text;

                ConnectClass.db.Parameters.Add(newParameteres);
                ConnectClass.db.Jewelry.Add(newJewelry);

                ConnectClass.db.SaveChanges();

                MessageBox.Show("Данные сохранены.", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка при сохранении!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        //Кнопка открытия изображения
        private void openBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "Image (*.png; *.jpeg; *.jpg;) | *.png; *.jpeg; *.jpg;";
                if (file.ShowDialog() == true)
                {
                    BitmapImage imgBitmap = new BitmapImage(new Uri(file.FileName));
                    imgLoad.Source = imgBitmap;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Выберите пожалуйста картинку.", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void priceTxb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void heightTxb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void widthTxb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void weightTxb_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }

        private void txbCount_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
