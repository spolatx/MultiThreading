using MultiThreadingExample.MailProviders.Base;
using MultiThreadingExample.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    public class MailManager
    {
        //birden fazla thread tarafından erişilebilir ve kullanılabilir olması için kullandığımız bir obje
        private readonly ConcurrentQueue<MailObject> mailObjects = new ConcurrentQueue<MailObject>();

        private readonly ConcurrentDictionary<MailProviderType, BaseProvider> mailProviders = new ConcurrentDictionary<MailProviderType, BaseProvider>();

        public void AddMails(IEnumerable<MailObject> mails)
        {
            foreach (var mail in mails)
            {
                mailObjects.Enqueue(mail);
            }
        }
        public async Task SendAllMails()
        {
            LogManager.Default.Log("SendAllMails started!");
            LogManager.Default.Log($"{mailObjects.Count} mails found!");

            var smtpProvider = new SmtpProvider();

            while (mailObjects.Count > 0)
            {
                //eğer listeden alabiliyorsa bunu listeden silip bu değişkenin içerisine atayacak.
                mailObjects.TryDequeue(out MailObject mail);
                //her seferinde yeni bir provider create etmedim listemin içerisinden gidip aldım.
                var provider = GetProvider(mail.MailProviderType);
                await smtpProvider.Send(mail);
            }


            LogManager.Default.Log($"SendAllmails finished");
        }

        //ona verdiğimiz tipe göre provider create edecek methodu yazalım.
        
        private BaseProvider GetProvider(MailProviderType mailProviderType)
        {
            return mailProviders.GetOrAdd(mailProviderType, x => MailProviderFactory.CreateProvider(mailProviderType));


            //burada bu providerı yine SendAllMails methodu içerisinde çağıracağımız için yine her seferinde SmtpProviderı generate etmiş olacağız bunun olmasını istemediğimiz için burada oluşturduğumuz her bir providerları da bir dictionary içerisinde tutmalıyız.
            //return mailProviderType switch
            //{
            //    MailProviderType.Smtp => new SmtpProvider(),
            //    _ => null
            //};
        }



    }
}
