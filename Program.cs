using System;

namespace CoreProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Core programs");
            Console.WriteLine("Press 1. for coin flip percentage");
            Console.WriteLine("Press 2. for leap year check");
            Console.WriteLine("Press 3. for power of 2 program");
            Console.WriteLine("Press 4. for Harmonic number");
            Console.WriteLine("Press 5. for prime Factorization");
            Console.WriteLine("Press 6. for Quotient and remainder");
            Console.WriteLine("Press 7. for swap numbers ");
            Console.WriteLine("Press 8. for Odd Even");
            Console.WriteLine("Press 9. For Vowel and Consonent check");
            Console.WriteLine("Press 10. For finding the largest number among the three number");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FlipCoin flipCoin = new FlipCoin();
                    flipCoin.PercentageFlips(100);
                    break;
                case 2:
                    CheckLeapYear checkLeapYear = new CheckLeapYear();
                    CheckLeapYear.LeapYear();
                    break;
                case 3:
                    powerof2 powerof2 = new powerof2();
                    powerof2.CheckPower();
                    break;
                case 4:
                    GenerateHarmonicNo generateHarmonicNo = new GenerateHarmonicNo();
                    GenerateHarmonicNo.HarmonicNumber();
                    break;
                case 5:
                    Factors factors = new Factors();
                    Factors.PrimeFactor();
                    break;
                case 6:
                    QuotandRem quotandRem = new QuotandRem();
                    QuotandRem.Divide();
                    break;
                case 7:
                    Swap swap = new Swap();
                    Swap.SwapNumber();
                    break;
                case 8:
                    EvenOdd evenOdd = new EvenOdd();
                    EvenOdd.CheckOddEven();
                    break;
                case 9:
                    VowelConsonent vowelConsonent = new VowelConsonent();
                    VowelConsonent.CheckVowel();
                    break;
                case 10:
                    Largest largest = new Largest();
                    largest.CheckLargest();
                    break;
            }
            Console.ReadLine();
        }
    }
}
