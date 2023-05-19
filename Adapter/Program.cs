using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            INotificationSender emailClient = new EmailSender();
            Notification tekst = new Notification()
            {
                Title = "Wiadomość od Mariana",
                Body = "Cześć tu Marian"
            };
            emailClient.SendNotification(133, tekst);

            INotificationSender pushClient = new PushSender();
            pushClient.SendNotification(211, tekst);

            INotificationSender smsClient = new SmsSenderAdapter();
            smsClient.SendNotification(16, tekst);

        }
    }
}
