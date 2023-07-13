using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Flipcoin
    {
        public void Play()
        {
            Random random = new Random();
            Console.WriteLine("Enter no. on times the coin need to be flipped");
            int num = Convert.ToInt32(Console.ReadLine());
            int headCount = 0, tailCount = 0;
            for(int i = 0; i < num; i++)
            {
                double check = random.NextDouble(); // in between 0 and 1
                if (check < 0.5)
                    tailCount++;
                else
                    headCount++;
            }
            double hper = (headCount / num) * 100;
            double tper = (tailCount / num) * 100;
            Console.WriteLine("Percentage of Head" + " " + hper);
            Console.WriteLine("Percentage of Tail" + " " + tper);
        }
    }
}
