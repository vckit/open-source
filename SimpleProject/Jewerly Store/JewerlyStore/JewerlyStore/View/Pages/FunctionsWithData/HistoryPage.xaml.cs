using JewerlyStore.Classes;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Word = Microsoft.Office.Interop.Word;

namespace JewerlyStore.View.Pages.FunctionsWithData
{
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public HistoryPage()
        {
            InitializeComponent();
            ChecksList.ItemsSource = ConnectClass.db.Check.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void dtpDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ChecksList.ItemsSource = ConnectClass.db.Check.Where(item => item.Date == dtpDate.SelectedDate).ToList();
        }

        private void AllCheck_Click(object sender, RoutedEventArgs e)
        {
            dtpDate.SelectedDate = null;
            ChecksList.ItemsSource = ConnectClass.db.Check.ToList();
        }

        private void btnExportPDF_Click(object sender, RoutedEventArgs e)
        {
            var word = new Word.Application();
            try
            {
                var documents = word.Documents.Add();
                var paragrah = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragrah.Range;
                var checksList = ConnectClass.db.Check.ToList();
                var table = documents.Tables.Add(tableRange, checksList.Count, 6);
                table.Borders.Enable = 1;
                table.Cell(1, 1).Range.Text = "ФИО Клиента";
                table.Cell(1, 2).Range.Text = "Изделие";
                table.Cell(1, 3).Range.Text = "Продано шт.";
                table.Cell(1, 4).Range.Text = "Телефон";
                table.Cell(1, 5).Range.Text = "Дата";
                table.Cell(1, 6).Range.Text = "Сумма";

                int i = 2;
                foreach (var item in checksList)
                {
                    table.Cell(i, 1).Range.Text = item.Client.FullName;
                    table.Cell(i, 2).Range.Text = item.Jewelry.JewelryCheckGet;
                    table.Cell(i, 3).Range.Text = item.Count.ToString();
                    table.Cell(i, 4).Range.Text = item.Client.Phone;
                    table.Cell(i, 5).Range.Text = item.Date.ToString();
                    table.Cell(i, 6).Range.Text = item.TotalPrice.ToString();
                    i++;
                }
                documents.SaveAs2(Environment.CurrentDirectory + @"Checks.pdf", Word.WdSaveFormat.wdFormatPDF);
                documents.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                if (MessageBox.Show("Документ PDF успешно сформирован. Хотите открыть его?", "Операция прошла успешно!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                {
                    Process.Start(Environment.CurrentDirectory + @"Checks.pdf");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }
    }
}
