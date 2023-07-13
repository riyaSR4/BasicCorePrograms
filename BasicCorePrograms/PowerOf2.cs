using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOf2
    {
        public void PrintPowerOf2()
        {
            Console.WriteLine("Enter the limit ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                double p = Math.Pow(2,i);
                Console.WriteLine(2 + "^" + i + "=" + p);
            }
        }
    }
}
