using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericReportGenerator
{
    /// <summary>
    /// Product class with Propeties like  ProductId, ProductName 
    /// </summary>
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public override string ToString()
        {
            return "Product ID: " + ProductId + " Name: " + ProductName;
        }

    }
}
