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
                Console.WriteLine("Enter input to be executed\n 1.Flip Coin\n 2.Leap Year\n 3.Power of 2\n 4.Exit");
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
                        PowerOf2 powerOf2 = new PowerOf2();
                        powerOf2.PrintPowerOf2();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}