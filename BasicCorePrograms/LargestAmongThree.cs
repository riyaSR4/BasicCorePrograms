using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestAmongThree
    {
        public void FindLargestAmongThree()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine(a + " is greater");
            }
            else if(b > a && b > c)
            {
                Console.WriteLine(b + " is greater");
            }
            else
            {
                Console.WriteLine(c + " is greater");
            }
        }
    }
}
