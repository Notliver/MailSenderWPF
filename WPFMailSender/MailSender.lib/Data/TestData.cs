using MailSender.lib.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Data
{
    public static class TestData
    {
        public static List<Server> Servers { get; } = new List<Server>
        {
            new Server {Name = "Yandex", Address = "smtp.yandex.ru", Port = 465, Login = "DefaultLogin", Password = "DefaultPassword"},
            new Server {Name = "Mail.ru", Address = "smtp.mail.ru", Port = 465, Login = "DefaultLogin", Password = "DefaultPassword"},
            new Server {Name = "Yandex", Address = "smtp.gmail.com", Port = 465, Login = "DefaultLogin", Password = "DefaultPassword"}
        };

        public static List<Sender> Senders { get; } = new List<Sender>
        {
            new Sender {Name = "Test1", Address = "Test1@yandex.ru"},
            new Sender {Name = "Test2", Address = "Test2@mail.ru"},
            new Sender {Name = "Test3", Address = "Test3@gmail.com"}
        };
    }
}
