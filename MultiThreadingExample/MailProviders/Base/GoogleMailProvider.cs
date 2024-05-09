using MultiThreadingExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample.MailProviders.Base
{
    public class GoogleMailProvider : BaseProvider
    {
        public override async Task Send(MailObject mailObject)
        {
           await Task.Delay(3000);
            LogManager.Default.Log($"Gmail has sent to {mailObject.To}");
        }
    }
}
