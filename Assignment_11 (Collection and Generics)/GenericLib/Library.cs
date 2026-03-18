using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;


namespace GenericLib
{
    /// <summary>
    /// This generic class is used for adding and display any item info using Product property
    /// This class having 2 Generic Methods "AddItem(T item)" set the Property 
    /// And DisplayItem() Display the product property
    /// </summary>
    /// <typeparam name="T"> Any type of Product</typeparam>
    public class Library<T>
    {
        public T Product { get; set; }

        public void AddItem(T item)
        {
            this.Product = item;
            HttpContext.Current.Response.Write("Item Added Successfully!!!" + "<br/>");
        }

        public void DisplayItem()
        {
            HttpContext.Current.Response.Write("Item Info : " + Product + "<br/>");
        }
    }
}
