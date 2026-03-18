using System;

namespace BankSystem
{
    /// <summary>
    /// Represents Saving Account operations.
    /// Implements IBank interface.
    /// </summary>
    public class SavingAccount : IBank
    {
        public string Deposit()
        {
            return "Saving Account Amount is deposited!!!";
        }

        public string WithDraw(double balance, double wamount)
        {
            // Saving account cannot withdraw more than balance
            if (wamount > balance)
            {
                return "From Saving Account Cannot withdraw more than balance!!!";
            }
            else
            {
                return $"From Saving Account {wamount} Amount is withdraw!!!";
            }
        }

        public string CheckBalance()
        {
            return "Your Saving Account Balance Amount info is also send to email!!!";
        }
    }
}