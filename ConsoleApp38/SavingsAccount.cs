using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class SavingsAccount :Account, IAccount
    {
        public SavingsAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
            Balance = 0;
        }
        public void CalculateInterest()
        {
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            //Balance = Balance + amount;
            Console.WriteLine($"Balance: {Balance} manat musteri nomresi {AccountNumber}");
        }

        public override double ShowAccountDetails()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            if (Balance >amount)
            {
                //Balance=Balance-amount
                Balance-=amount;
                Console.WriteLine($"Balance: {Balance} manat");
            }
        }
    }
}
