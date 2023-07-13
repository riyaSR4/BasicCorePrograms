using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientReminder
    {
        public void PrintQuotientReminder()
        {
            int quot = 0, rem = 0;
            Console.WriteLine("Enter the first number ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number ");
            int b = Convert.ToInt32(Console.ReadLine());
            quot = a / b;
            rem = a % b;
            Console.WriteLine("Quotient is " + quot);
            Console.WriteLine("Reminder is " + rem);
        }
    }
}
