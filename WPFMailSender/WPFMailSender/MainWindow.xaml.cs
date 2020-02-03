using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security;
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

namespace WPFMailSender
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void OnSendButtonClick(object sender, RoutedEventArgs e)
        //{
            
        //    const string from = "akurganskiy@yandex.ru";
        //    const string to = "akurganskii@gmail.com";

        //    try
        //    {
        //        using (var message = new MailMessage(from, to))
        //        {
        //            message.Subject = MailSubject.Text;
        //            message.Body = MailBody.Text;


        //            const string server_address = "smtp.yandex.ru";
        //            const int server_port = 25;
        //            using (var client = new SmtpClient(server_address, server_port))
        //            {
        //                client.EnableSsl = true;

        //                var user_name = UserNameEdit.Text;
        //                SecureString user_password = PasswordEdit.SecurePassword;

        //                client.Credentials = new NetworkCredential(user_name, user_password);

        //                client.Send(message);

        //                MessageBox.Show("Письмо ушло","Successfully",
        //                    MessageBoxButton.OK, MessageBoxImage.Information);
        //            }
        //        }
        //    }
        //    catch (Exception error)
        //    {
        //        MessageBox.Show(error.Message, "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}
    }
}
