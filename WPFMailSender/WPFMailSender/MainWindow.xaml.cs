using System.Windows;
using MailSender.lib.Data;
using MailSender.lib.Entities;
using MailSender.lib.Service;



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

        private void OnSendButtonClick(object Sender, RoutedEventArgs e)
        {
            var recipient = RecipientsList.SelectedItem as Recipient;
            var sender = SenderList.SelectedItem as Sender;
            var server = ServersList.SelectedItem as Server;

            if (recipient is null || server is null || sender is null) return;

            var mail_sender = new MailSender.lib.Services.MailSender(server.Address,
                                                          server.Port,
                                                          server.UseSSL,
                                                          server.Login,
                                                          server.Password.Decode(3));

            mail_sender.Send(MailHeader.Text, MailBody.Text, sender.Address, recipient.Address);
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
