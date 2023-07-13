using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Swap
    {
        public void SwapTwoNumbers()
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping : a = " + a + ", b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After Swapping : a = " + a + ", b = " + b);
        }
    }
}
