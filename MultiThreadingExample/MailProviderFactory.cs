using MultiThreadingExample.MailProviders.Base;
using MultiThreadingExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    public class MailProviderFactory
    {
        public static BaseProvider CreateProvider(MailProviderType mailProviderType)
        {
            return mailProviderType switch
            {
                MailProviderType.Smtp => new SmtpProvider(),
                MailProviderType.Gmail=>new GoogleMailProvider(),
                _=> throw new NotSupportedException(),
            };
        }
    }
}
