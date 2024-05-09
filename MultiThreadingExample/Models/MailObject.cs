using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample.Models
{
    public class MailObject
    {
        public string To { get; set; }
        public string From { get; set; } = "spolat953@gmail.com";

        public MailProviderType MailProviderType { get; set; }

    }
    public enum MailProviderType
    {
        Smtp = 1,
        Gmail=2,
    }
}

