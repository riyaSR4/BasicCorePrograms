using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void PrintHarmonicNumber()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            float a=0, b;
            for (float i = 1; i <= n; i++)
            {
                b = 1 / i;
                a = a + b;
            }
            Console.WriteLine("nth harmonic number :" + " " + a);
        }
    }
}
