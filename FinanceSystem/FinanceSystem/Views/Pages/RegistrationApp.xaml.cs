using FinanceSystem.Context;
using FinanceSystem.Model;
using JewerlyStore.HelperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace FinanceSystem.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationApp.xaml
    /// </summary>
    public partial class RegistrationApp : Page
    {
        public RegistrationApp()
        {
            InitializeComponent();
        }

        private void ButtonSignUp_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (HelperObject.IsValidEmail(EmailTextBox.Text))
                {
                    if(dbContext.db.SignIn.Count(item => item.Username == EmailTextBox.Text) > 0)
                    {
                        MessageBox.Show("Учётная запись существует. Пожалуйста, если вы потеряли доступ, обратитесь к Администартору Системы.",
                        "В доступе отказано!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    else
                    {
                        SendMessage();
                        SignIn signIn = new SignIn();
                        Employe employe = new Employe();
                        employe.FirstName = FirstNameTextBox.Text;
                        employe.LastName = LastNameTextBox.Text;
                        employe.Patronymic = PatronymicTextBox.Text;
                        employe.Email = EmailTextBox.Text;
                        employe.Phone = PhoneTextBox.Text;
                        signIn.Username = EmailTextBox.Text;
                        signIn.Password = currentPassword;

                        dbContext.db.Employe.Add(employe);
                        dbContext.db.SignIn.Add(signIn);
                        dbContext.db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный формат почты! Пожалуйста, внимательно прочтите, какой набор символов вы ввели и повторите попытку!",
                          "Некорректный формать логина!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static string GenericPassword()
        {
            // Получаем количество слов и букв за слово.
            int num_letters = 8;
            int num_words = 1;

            // Создаем массив букв, которые мы будем использовать.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdifghijklmnopqrstuvwxyz123456789".ToCharArray();

            // Создаем генератор случайных чисел.
            Random rand = new Random();

            // Сделайте слово.
            string word = "";
            // Делаем слова.
            for (int i = 1; i <= num_words; i++)
            {
                for (int j = 1; j <= num_letters; j++)
                {
                    // Выбор случайного числа от 0 до 25
                    // для выбора буквы из массива букв.
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Добавить письмо.
                    word += letters[letter_num];
                }
            }
            return word;
        }

        static string currentPassword = GenericPassword();


        private async void SendMessage()
        {
            try
            {   // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("jewralyapp@mail.ru", "Admin FinanceApp SoftWare");
                // кому отправляем
                MailAddress to = new MailAddress(EmailTextBox.Text);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Администратор одобрил ваш запрос!";
                // текст письма
                m.Body = "<h2>Ваш логин: " + EmailTextBox.Text + ", Ваш пароль: " + currentPassword + " </h2>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                // логин и пароль
                smtp.Credentials = new NetworkCredential("jewralyapp@mail.ru", "@Lucky090");
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(m);
                MessageBox.Show("Ваш запрос отправлен, Администратор системы рассмотрит ваш запрос как можно быстрее. Дождитесь пожалуйста ответа.",
                    "Запрос успешно отправлен!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

    }
}
