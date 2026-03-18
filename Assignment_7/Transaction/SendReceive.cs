using System;
using System.Web;

namespace Transaction
{
    /// <summary>
    /// Represents a simple account used for transferring money
    /// between two users.
    /// </summary>
    public class SendReceive
    {
        // Employee ID (cannot be modified after object creation)
        public int EmpID { get; }

        // Employee Name (read-only after initialization)
        public string EmpName { get; }

        // Current account balance
        public double Balance;

        /// <summary>
        /// Constructor used to initialize account details.
        /// </summary>
        public SendReceive(int empID, string empName, double balance)
        {
            this.EmpID = empID;
            this.EmpName = empName;
            this.Balance = balance;
        }

        /// <summary>
        /// Transfers amount from sender to receiver account.
        /// </summary>
        /// <param name="sender">Account sending money</param>
        /// <param name="receiver">Account receiving money</param>
        /// <param name="amount">Amount to transfer</param>
        public static void TransferAmount(SendReceive sender, SendReceive receiver, double amount)
        {
            // Check if sender has sufficient balance
            if (sender.Balance <= amount)
            {
                HttpContext.Current.Response.Write("Insufficient Amount to send!!!");
            }
            else
            {
                // Deduct amount from sender
                sender.Balance -= amount;

                // Add amount to receiver
                receiver.Balance += amount;
            }
        }
    }
}