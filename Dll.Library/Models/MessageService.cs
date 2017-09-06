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
    public class MessageService : IMessageEncoder
    {
        public Message Message { get; set; }

        public MessageService(Message message)
        {
            Message = message;
        }
        public void MessageEncode(Mail mail)
        {
            Console.WriteLine(mail.MailType);
        }

        public void Encoded(object source, EventArgs e)
        {
            Console.WriteLine("Zprava se vam prave enkoduje na vasi obrazovku..." + Message.MessageType);
            Thread.Sleep(2000);
        }
        public void MessageEncode(Message message)
        {
            var type = message.MessageType;
            Console.WriteLine(type);
            Thread.Sleep(3000);
        }
    }
}
