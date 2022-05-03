using System;

namespace DheerajG_Logical
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1 - Fizz Buzz
            printNumber(100);


            // Question 2 - N * M Grid
            string val1, val2;
            Console.Write("Enter N: ");
            val1 = Console.ReadLine();
            Console.Write("Enter M: ");
            val2 = Console.ReadLine();
            int n = Convert.ToInt32(val1);
            int m = Convert.ToInt32(val2);
            printGrid(n, m);
            Console.ReadLine();
        }

        public static void printNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (i % 5 == 0 || i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                Console.WriteLine("{0} ", i);
            }
        }

        public static void printGrid(int n, int m)
        {
            for (n = 1; n <= 8; n++)
            {
                for (m = 1; m <= 4; m++)
                {
                    Console.Write("#" + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
