using System;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Entities
{
    /// <summary>
    /// Mail server
    /// </summary>
    public class Server
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int Port { get; set; }

        public bool UseSSL { get; set; } = true;

        public string Login { get; set; }

        public string Password { get; set; }
    }
}
