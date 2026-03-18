using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDetails
{
    public class Order
    {

        public int TotalAmount { get; set; }
        public int OrderNumber { get; set; }

        public Order PlaceOrder(int totalAmount, int orderNumber)
        {
            Order ord = new Order();

            if (totalAmount > 1000)
            {
                ord.TotalAmount = totalAmount - 100;
            }
            else {

                ord.TotalAmount = totalAmount;
            }

            ord.OrderNumber = orderNumber;

            return ord;
        }

    }
}
