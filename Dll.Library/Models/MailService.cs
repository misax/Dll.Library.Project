using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dll.Library.Data;

namespace Dll.Library.Models
{
    public class MailService : IMost
    {
        public Mail Mail { get;set; }
        public MailService(Mail mail)
        {
            Mail = mail;
        }
        public void SendMail(object o, EventArgs e)
        {
            Console.WriteLine("Prave se nahral pro vas vzkaz a posila se mailem...");
            Thread.Sleep(4000);
        }

        public void DisplayTerms(object sender, VideoEventArgs ars)
        {
            Console.WriteLine($"Druh poslane zpravy {Mail.MailType}");
        }
    }
}
