using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter input to be executed\n 1.Flip Coin\n 2.Leap Year\n 3.Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Flipcoin flipcoin = new Flipcoin();
                        flipcoin.Play();
                        break;
                    case 2:
                        LeapYear leapYear = new LeapYear();
                        leapYear.CheckLeapYear();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}