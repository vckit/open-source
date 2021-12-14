using JewerlyStore.Classes;
using JewerlyStore.DB;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Jewelry selectedItem;
        public EditPage(Jewelry selectedItem)
        {
            InitializeComponent();
            this.selectedItem = selectedItem;

            categoryCmb.ItemsSource = ConnectClass.db.Category.Select(item => item.Title).ToList();

            //Передача изображения на страницу
            if (selectedItem.JewImg != null)
            {
                BitmapImage bitmap = new BitmapImage();
                using (MemoryStream stream = new MemoryStream(selectedItem.JewImg))
                {
                    bitmap.BeginInit();
                    bitmap.CacheOption = BitmapCacheOption.OnLoad;
                    bitmap.StreamSource = stream;
                    bitmap.EndInit();
                }
                imgLoad.Source = bitmap;
            }

            jewNameTxb.Text = selectedItem.JewName;
            categoryCmb.SelectedItem = selectedItem.Category.Title;
            materialTxb.Text = selectedItem.Material;
            priceTxb.Text = Convert.ToString(selectedItem.Pice);
            heightTxb.Text = selectedItem.Parameters.Height;
            widthTxb.Text = selectedItem.Parameters.Width;
            weightTxb.Text = selectedItem.Parameters.Weight;
            txbCount.Text = selectedItem.Count.ToString();
        }

        //Кнопка назад
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        //Кнопка изменения
        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                var editJewelry = ConnectClass.db.Jewelry.FirstOrDefault(item => item.ID == selectedItem.ID);

                //Добавление изображения
                MemoryStream stream = new MemoryStream();
                JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create((BitmapImage)imgLoad.Source));
                encoder.Save(stream);
                editJewelry.JewImg = stream.ToArray();

                editJewelry.JewName = jewNameTxb.Text;
                editJewelry.Category.Title = categoryCmb.Text;
                editJewelry.Material = materialTxb.Text;
                editJewelry.Pice = Convert.ToInt64(priceTxb.Text);
                editJewelry.Parameters.Height = heightTxb.Text;
                editJewelry.Parameters.Width = widthTxb.Text;
                editJewelry.Parameters.Weight = weightTxb.Text;
                editJewelry.Count = Convert.ToInt32(txbCount.Text);

                ConnectClass.db.SaveChanges();

                MessageBox.Show("Данные успешно обновились.", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
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
            catch
            {
                MessageBox.Show("Выберите пожалуйста картинку.", "Произошла ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void priceTxb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;

        }

        private void heightTxb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;

        }

        private void widthTxb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;

        }

        private void weightTxb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;

        }

        private void txbCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}
