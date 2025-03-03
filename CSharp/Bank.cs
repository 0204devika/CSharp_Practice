using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Bank
    {
        public int Balance { get; set; }
        public static int InterestRate { get; set; } = 2; 

        public Bank(int balance)
        {
            Balance = balance;
        }

        public static void SetInterestRate(int rate)
        {
            InterestRate = rate;
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Balance: {Balance}, Interest Rate: {InterestRate}%");
        }
    }
}
