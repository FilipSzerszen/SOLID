using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class SmsSenderAdapter : INotificationSender
    {
        private SmsSender _smsSender = new SmsSender();

        public void SendNotification(int userId, Notification notification)
        {
            string userPhoneNummber = "+76 255 433 388"; //<- np userId.GetTelephone();
            _smsSender.SendSms(userPhoneNummber,  notification.Body.ToString());
        }
    }
}
