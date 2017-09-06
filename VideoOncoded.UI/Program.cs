using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dll.Library.Data;
using Dll.Library.Models;

namespace VideoOncoded.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryCreate factor = new Factory{Factory1 = "Tovarna 1"};
            Factory factory = new Factory();
            factory.CreateFactory += Factory_CreateFactory;

            factory.NameOfDelegate(factor);
       



            Video video = new Video() {NameOfVideo = "Johny Depp", Title = "Film"};

            Mail mail = new Mail() {MailType = "Email service"};
            Message message = new Message() {MessageType = "Post mail"};
            MessageService messageService = new MessageService(message);
            MailService mailService = new MailService(mail);
            VideoEncoder encoder = new VideoEncoder(video);
            encoder.OnVideoDemand += messageService.Encoded;
            encoder.OnVideoDemand += mailService.SendMail;
            encoder.OnVideoDemand += mailService.DisplayTerms;
            encoder.Encode(video);
        }

        private static void Factory_CreateFactory(object o, EventArgs e)
        {
            int id = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Raise your event " + ++id);  
                Thread.Sleep(3000);
            }
          
        }
    }
}
