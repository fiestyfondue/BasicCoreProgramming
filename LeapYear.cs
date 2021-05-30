using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class CheckLeapYear
    {
        
        public static void LeapYear()
        {
            Console.WriteLine("Enter the year ");
            int year;
            year = Convert.ToInt32(Console.ReadLine());
            if (year <= 999)
            {
                Console.WriteLine("Invalid year");

            }
            else if (year % 4 == 0 || year % 100 != 0 && year % 4 == 0)
            {
                Console.WriteLine($"{year} is a Leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}
