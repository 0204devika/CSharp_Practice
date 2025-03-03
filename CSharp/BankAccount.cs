using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class BankAccount
    {
        private int balance;

        public void Deposit(int balance,int amount)
        {
            balance = balance + amount;
            Console.WriteLine("Amount deposited successfully " +balance);
        }
        public void Withdraw(int balance,int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("Amount Withdrawm successfully " +balance);
            }
        }
    }
}
