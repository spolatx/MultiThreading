using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingExample
{
    public class LogManager
    {
        private static LogManager logManager;

        //??= operatörünü kullanarak, logManager null ise yeni bir LogManager nesnesi oluşturulur ve logManager alanına atama yapılır. Bu sayede LogManager nesnesi yalnızca bir kez oluşturulur ve sonraki çağrılarda tekrar oluşturulmaz, aynı nesne döndürülür. Bu desen, "Lazy Initialization" (Tembel Başlatma) olarak bilinir ve nesnenin gerektiği zaman oluşturulmasını sağlar, bu da gereksiz bellek kullanımını önler
        public static LogManager Default => logManager ??= new LogManager();

        public event EventHandler<string> OnLogAdded;

        public void Log(string logMessage)
        {
            OnLogAdded?.Invoke(this, logMessage);
        }
    }
}
