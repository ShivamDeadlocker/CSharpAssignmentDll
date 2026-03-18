using System;
using System.Collections.Generic;

namespace SmartVendingMaachine
{
    /// <summary>
    /// Represents a vending machine that manages products,
    /// validates purchase requests and processes transactions.
    /// </summary>
    public class VendingMachine
    {
        // List to store available products
        public List<Product> Products = new List<Product>();

        /// <summary>
        /// Initializes vending machine with default products.
        /// </summary>
        public VendingMachine()
        {
            Products.Add(new Product("late cafe", 100, 10));
            Products.Add(new Product("milk", 40, 20));
            Products.Add(new Product("hot chocolate", 70, 5));
            Products.Add(new Product("lemon tea", 15, 15));
            Products.Add(new Product("hot water", 10, 50));
        }

        /// <summary>
        /// Handles product purchase logic including stock and payment validation.
        /// </summary>
        /// <param name="index">Selected product index</param>
        /// <param name="quantity">Requested quantity</param>
        /// <param name="money">Amount inserted by user</param>
        /// <returns>Transaction result message</returns>
        public string BuyProduct(int index, int quantity, int money)
        {
            // Validate product selection
            if (index < 0 || index >= Products.Count)
            {
                return "Invalid Selection!!! Please Select the Correct Product";
            }

            Product product = Products[index];

            // Validate quantity
            if (quantity <= 0)
            {
                return "Enter the valid quantity!!!";
            }

            // Check stock availability
            if (product.Quantity < quantity)
            {
                return "Insufficient Stock in inventory!!!!";
            }

            int totalAmount = product.Price * quantity;

            // Check if inserted money is sufficient
            if (money < totalAmount)
            {
                return "Insufficient Amount!!!!";
            }

            // Deduct purchased quantity
            product.Quantity -= quantity;

            int change = money - totalAmount;

            // Return transaction details
            return "<br/> Product Name: " + product.Name +
                   "<br/> Requested Quantity: " + quantity +
                   "<br/> Total Amount to Pay: " + totalAmount +
                   "<br/> Getting Change : " + change;
        }
    }

    /// <summary>
    /// Represents a product inside the vending machine.
    /// </summary>
    public class Product
    {
        // Product properties
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// Creates a product with name, price and available quantity.
        /// </summary>
        public Product(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}