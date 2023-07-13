using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factors
    {
        public void PrintFactors()
        {
            Console.WriteLine("Enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int isPrime;
            Console.WriteLine("The prime factors are :");
            for (int i = 2; i<=n; i++)
            {
                if(n % i == 0)
                {
                    isPrime = 1;
                    for (int j = 2; j <= i/2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
