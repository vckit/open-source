using JewerlyStore.Classes;
using JewerlyStore.DB;
using JewerlyStore.HelperClass;
using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace JewerlyStore.View.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationPageView.xaml
    /// </summary>
    public partial class RegistrationPageView : Page
    {

        public RegistrationPageView()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (HelperObject.IsValidEmail(txbEmail.Text))
                {
                    if (ConnectClass.db.Regisration.Count(item => item.Email == txbEmail.Text) > 0)
                    {
                        MessageBox.Show("Учётная запись существует. Пожалуйста, если вы потеряли доступ, обратитесь к Администартору Системы.",
                        "В доступе отказано!", MessageBoxButton.OK, MessageBoxImage.Warning);
                        return;
                    }
                    else
                    {
                        SendMessage();
                        Regisration regisration = new Regisration();
                        SignIn signIn = new SignIn();
                        signIn.LogIn = txbEmail.Text;
                        signIn.Password = currentPassword;
                        signIn.RoleID = "A";
                        regisration.Email = txbEmail.Text;
                        regisration.FirstName = txbFirstName.Text;
                        regisration.LastName = txbLastName.Text;
                        regisration.Patronymic = txbPatronymic.Text;
                        regisration.NumberContract = txbNumberContract.Text;
                        regisration.Date = DateTime.Now;
                        regisration.IDUser = signIn.ID;
                        ConnectClass.db.SignIn.Add(signIn);
                        ConnectClass.db.Regisration.Add(regisration);
                        ConnectClass.db.SaveChanges();
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
                MailAddress from = new MailAddress("jewralyapp@mail.ru", "Admin JewralyApp SoftWare");
                // кому отправляем
                MailAddress to = new MailAddress(txbEmail.Text);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Администратор одобрил ваш запрос!";
                // текст письма
                m.Body = "<h2>Ваш логин: " + txbEmail.Text + ", Ваш пароль: " + currentPassword + " </h2>";
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

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
