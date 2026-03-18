using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    public class OrderService 
    {
        private readonly IPayment payment;
        private readonly INotification notification;
        private readonly ILogger logs;

        public OrderService(IPayment Payment, INotification Notification, ILogger Logs)
        {
            this.payment = Payment;
            this.notification = Notification;
            this.logs = Logs;
        }

        public string Payment(string msg)
        {
            return payment.PaymentProcess(msg);
        }

        public string Notification(string msg)
        {
            return notification.Notification(msg);
        }

        public string Logs(string msg)
        {
            return logs.Logs(msg);
        }


    }
}
