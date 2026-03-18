using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReportGenerator
{
    /// <summary>
    /// Order class with Propeties like  OrderId, CustomerName 
    /// </summary>
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public override string ToString()
        {
            return "Order ID: " + OrderId + " Customer: " + CustomerName;
        }
    }
}
