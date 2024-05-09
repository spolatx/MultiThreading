using MultiThreadingExample.Models;

namespace MultiThreadingExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LogManager.Default.OnLogAdded += (s, e) => { AddLog(e); };
        }
        private void AddLog(string logMessage)
        {
            if (lblLogs.InvokeRequired)
            {
                lblLogs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }

            logMessage = $"[{DateTime.Now:dd.MM.yyyy HH:mm:ss:fff}]-{logMessage}";
            lblLogs.Items.Add(logMessage);
            lblLogs.SelectedItem = lblLogs.Items.Count - 1;
        }

        private void btnListMailTasks_Click(object sender, EventArgs e)
        {
            var smtpMailTask = new MailTask(MailProviderType.Smtp)
            {
                Second = 10
            };
            var googleMailTask = new MailTask(MailProviderType.Gmail)
            {
                Second = 60
            };

            mailTaskBindingSource.Clear();
            mailTaskBindingSource.Add(smtpMailTask);
            mailTaskBindingSource.Add(googleMailTask);

        }

        private void mailTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            if (mailTask == null) return;

            btnStart.Enabled = !mailTask.IsStarted;
            btnStop.Enabled = mailTask.IsStarted;
            btnRun.Enabled = !mailTask.IsRunning && mailTask.IsStarted;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;
            mailTask.Stop();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            var mailTask = mailTaskBindingSource.Current as MailTask;

            await mailTask.Run(50);
        }
    }
}
