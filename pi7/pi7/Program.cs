using System;

namespace pi
{
    public class Programm
    {
        // сумма чисел
        public static int CountSum(int a, int b) => a + b;

        // числа одинаковой четности
        public static bool TheSameParity(int a, int b) => a % 2 == b % 2;

        // числа разной четности
        public static bool DifferentParity(int a, int b) => !TheSameParity(a, b);


        static void Main()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < 10; i++)
            {
                a++;
                if (a > 5) { b++; }
                else { c++; }
            }

            Console.WriteLine("Hello");
            Console.WriteLine(CountSum(b, c));
            Console.WriteLine(TheSameParity(a, b));
            Console.WriteLine(DifferentParity(a, c));
        }
    }
}

