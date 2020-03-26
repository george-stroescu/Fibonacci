using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;
            int n;
            Console.Write("Enter the last element of the Fibonacci series: ");
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out n) && n > 1;

                if(!isNumber)
                {
                    Console.WriteLine("Enter a number");
                }
            }
            while (!isNumber);

            int f0 = 0, f1 = 1, fn;

            Console.Write($"{f0} {f1} ");

            for (int i = 2; i < n; i++)
            {
                fn = f0 + f1;
                Console.Write($"{fn} ");
                f0 = f1;
                f1 = fn;
            }
        }
    }
}
