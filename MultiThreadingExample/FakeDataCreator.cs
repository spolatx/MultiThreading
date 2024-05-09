using MultiThreadingExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    public class FakeDataCreator
    {
        public static IEnumerable<MailObject> GetSmtpMails(int number)
        {
           return GetMails(number, MailProviderType.Smtp);
        }
        public static IEnumerable<MailObject> GetGoogleMails(int number)
        {
            return GetMails(number, MailProviderType.Gmail);
        }

        public static IEnumerable<MailObject> GetMails(int number , MailProviderType?  mailProviderType=null)
        {
            Bogus.Faker<MailObject> Faker = new Bogus.Faker<MailObject>().RuleFor(i => i.To, y => y.Internet.Email()).RuleFor(i => i.MailProviderType, y => !mailProviderType.HasValue
            ? y.PickRandom<MailProviderType>() :mailProviderType );
            return Faker.Generate(number);
        }
    }
}  
