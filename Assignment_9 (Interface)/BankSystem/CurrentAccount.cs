using System;

namespace BankSystem
{
    /// <summary>
    /// Represents Current Account operations.
    /// Allows overdraft withdrawal.
    /// </summary>
    public class CurrentAccount : IBank
    {
        public string Deposit()
        {
            return "Current Account Amount is deposited!!!";
        }

        public string WithDraw(double balance, double wamount)
        {
            // Current account allows overdraft
            if (wamount > balance)
            {
                return $"From Current Account {wamount} amount can withdraw with overdraft limit!!!";
            }
            else
            {
                return $"From Current Account {wamount} Amount is withdraw!!!";
            }
        }

        public string CheckBalance()
        {
            return "Your Current Account Balance Amount info is also send to email!!!";
        }
    }
}