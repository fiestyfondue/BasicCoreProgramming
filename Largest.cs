using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class Largest
    {
        public void CheckLargest()
        {
            Console.WriteLine("Enter the three values for comparison");

            int number1, number2, number3;
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());


            if (number1 == number2 && number2 == number3)
                Console.WriteLine("All inputs are equal");
            if (number1 > number2 && number1 > number3)
                Console.WriteLine($"{number1} is greater");
            if (number2 > number1 && number2 > number3)
                Console.WriteLine($"{number2} is greater");
            if (number3 > number1 && number3 > number2)
                Console.WriteLine($"{number3} is greater");
        }
    }
}
