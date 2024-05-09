using MultiThreadingExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample.MailProviders.Base
{
    public abstract class BaseProvider
    {
        public int Port { get; set; } = 587;
        public string ServerHostName { get; set; } = "smtp.google.com";
        public abstract Task Send(MailObject mailObject);
    }
}
