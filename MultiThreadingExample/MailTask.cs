using MultiThreadingExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    public class MailTask : INotifyPropertyChanged
    {
        private bool isRunning;
        private bool isStarted;
        private DateTime? nextRunning;

        public Guid TaskId { get; set; } = Guid.NewGuid();
        public MailProviderType MailProviderType { get; set; }

        public MailTask(MailProviderType mailProviderType)
        {
            MailProviderType = mailProviderType;
        }

        public bool IsRunning
        {
            get => isRunning;
            set
            {
                isRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));
            }
        }
        public bool IsStarted
        {
            get => isStarted;
            set
            {
                isStarted = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsStarted)));
            }
        }
        public int Second { get; set; } = 60;
        public DateTime? NextRunning
        {
            get => nextRunning;
            set
            {
                nextRunning = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(NextRunning)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public async Task Run(int number)
        {
            var manager = new MailManager();
            while (IsStarted)
            {
                IsRunning = true;

                IEnumerable<MailObject> mailObjects = Enumerable.Empty<MailObject>();

                if (MailProviderType==MailProviderType.Gmail)
                    mailObjects = FakeDataCreator.GetGoogleMails(number);
                else if (MailProviderType==MailProviderType.Smtp)
                    mailObjects = FakeDataCreator.GetSmtpMails(number);
                else
                    mailObjects = FakeDataCreator.GetMails(number);

                manager.AddMails(mailObjects);

                await manager.SendAllMails();

                IsRunning = false;

                NextRunning = DateTime.Now.AddSeconds(Second);
                await Task.Delay(Second * 1000);
            }
        }
        public void Start()
        {
            IsStarted = true;
            NextRunning = DateTime.Now.AddSeconds(Second);
        }
        public void Stop()
        {
            IsStarted = false;
            NextRunning = null;
        }
    }
}
