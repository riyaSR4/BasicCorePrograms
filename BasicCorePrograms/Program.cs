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
                Console.WriteLine("Enter input to be executed\n 1.Flip Coin\n 2.Leap Year\n 3.Power of 2\n 4.Factors\n" +  
                    " 5.Quotient and Reminder\n 6.Swap two numbers\n 7.Even or Odd\n 8.Vowel or Consonant\n" +
                    " 9.Exit");
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
                        Factors factors = new Factors();
                        factors.PrintFactors();
                        break;
                    case 5:
                        QuotientReminder quotientReminder = new QuotientReminder();
                        quotientReminder.PrintQuotientReminder();
                        break;
                    case 6:
                        Swap swap = new Swap();
                        swap.SwapTwoNumbers();
                        break;
                    case 7:
                        EvenOrOdd evenOrOdd = new EvenOrOdd();
                        evenOrOdd.CheckOddOrEven();
                        break;
                    case 8:
                        VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                        vowelOrConsonant.CheckVowelOrConsonant();
                        break;
                    case 9:
                        flag = false;
                        break;
                }
            }
        }
    }
}