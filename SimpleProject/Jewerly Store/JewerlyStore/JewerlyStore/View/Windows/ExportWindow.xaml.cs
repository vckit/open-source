using JewerlyStore.Classes;
using JewerlyStore.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows;
using Word = Microsoft.Office.Interop.Word;


namespace JewerlyStore.View.Windows
{
    /// <summary>
    /// Interaction logic for ExportWindow.xaml
    /// </summary>
    public partial class ExportWindow : Window
    {
        public ExportWindow()
        {
            InitializeComponent();
        }
        private void ExportPDF()
        {
            var word = new Word.Application();
            try
            {
                var document = word.Documents.Add();
                var paragraph = word.ActiveDocument.Paragraphs.Add();
                var tableRange = paragraph.Range;
                var jewerlyList = ConnectClass.db.Jewelry.ToList();
                var table = document.Tables.Add(tableRange, jewerlyList.Count, 8);
                table.Borders.Enable = 1;
                table.Cell(1, 0).Range.Text = "ID";
                table.Cell(1, 1).Range.Text = "Наименование";
                table.Cell(1, 2).Range.Text = "Категория";
                table.Cell(1, 3).Range.Text = "Материал";
                table.Cell(1, 4).Range.Text = "Цена";
                table.Cell(1, 5).Range.Text = "Высота";
                table.Cell(1, 6).Range.Text = "Ширина";
                table.Cell(1, 7).Range.Text = "Вес";
                table.Cell(1, 8).Range.Text = "Количество";

                int i = 2;
                foreach (var item in jewerlyList)
                {
                    table.Cell(i, 0).Range.Text = item.ID.ToString();
                    table.Cell(i, 1).Range.Text = item.JewName;
                    table.Cell(i, 2).Range.Text = item.Category.Title;
                    table.Cell(i, 3).Range.Text = item.Material;
                    table.Cell(i, 4).Range.Text = item.Pice.ToString();
                    table.Cell(i, 5).Range.Text = item.Parameters.Height;
                    table.Cell(i, 6).Range.Text = item.Parameters.Width;
                    table.Cell(i, 7).Range.Text = item.Parameters.Weight;
                    table.Cell(i, 8).Range.Text = item.Count.ToString();
                    i++;
                }
                document.SaveAs2(Environment.CurrentDirectory + "parts.docx");
                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
                MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source + " выдал исключение!", MessageBoxButton.OK, MessageBoxImage.Error);
                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
            }
        }
        private void ExportJSON()
        {
            var jewelry = ConnectClass.db.Jewelry.ToList();
            var option = new JsonSerializerOptions() { Encoder = JavaScriptEncoder.Create(UnicodeRanges.All) };
            string line = JsonSerializer.Serialize<List<Jewelry>>(jewelry, option);
            File.WriteAllText(Environment.CurrentDirectory + "parts.json", line);
            MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ExportCSV()
        {
            using (FileStream stream = new FileStream(Environment.CurrentDirectory + "parts.csv", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    var service = ConnectClass.db.Jewelry.ToList();
                    writer.WriteLine("Название;Категория;Материал;Цена;Высота;Ширина;Вес;Количество");
                    foreach (var item in service)
                    {
                        writer.WriteLine($"{item.JewName};{item.JewName};{item.Category.Title};{item.Material};{item.Pice};{item.Parameters.Height};{item.Parameters.Width};{item.Parameters.Weight};{item.Count}");
                    }
                }
            }
            MessageBox.Show("Сохранение прошло успешно!", "Сохранено!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void btnPDF_Click(object sender, RoutedEventArgs e)
        {
            ExportPDF();
            if (MessageBox.Show("Документ DOCX успешно сформирован. Хотите открыть его?", "Операция прошла успешно!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Process.Start(Environment.CurrentDirectory + @"parts.docx");
            }
            this.Close();
        }

        private void btnCSV_Click(object sender, RoutedEventArgs e)
        {
            ExportCSV();
            if (MessageBox.Show("Документ CSV успешно сформирован. Хотите открыть его?", "Операция прошла успешно!", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Process.Start(Environment.CurrentDirectory + @"parts.csv");
            }
            this.Close();
        }
    }
}
