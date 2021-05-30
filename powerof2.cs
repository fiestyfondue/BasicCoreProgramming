using System;
using System.Collections.Generic;
using System.Text;

namespace CoreProg
{
    class powerof2
    {
        public static int CheckPower()
        {
            Console.WriteLine("Enter the power of 2 you want:");
            int power;
            power = Convert.ToInt32(Console.ReadLine());
            if (power < 0 || power > 31)
            {
                Console.WriteLine("invalid power N");
                return 0;
            }
            int number, num = 1;
            for (number = 0; number <= power; number++)
            {
                if (number == 0)
                {
                    Console.WriteLine($"2^{number}={1}");
                    continue;
                }
                num *= 2;
                Console.WriteLine($"2^{number}={num}");
            }
            return 0;
        }
    }
}
