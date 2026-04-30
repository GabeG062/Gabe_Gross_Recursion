using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            Console.WriteLine("n is equal to " + n);
            PrintFibonacciNumbers(n);
        }

        static void PrintFibonacciNumbers(int n)
        {
            int fiboNumber = n;
            int fiboCarry = 0;
            int fiboNegOne = n-1;
            int fiboNegTwo = n-2;
            int fibonacci = 0;
            if (n == 0) return;
            while (fiboNumber != 0)
            {
                while (fiboNumber > 2)
                {
                    fiboCarry += fiboNegOne;
                    fiboCarry += fiboNegTwo;
                    fiboNumber--;
                }
                while (fiboNumber == 2)
                {
                    fiboCarry = 1;
                    fiboNumber--;
                }
                while (fiboNumber == 1)
                {
                    fiboCarry = 1;
                    fiboNumber--;
                }
            }
            fibonacci = fiboCarry;
            Console.WriteLine(fibonacci);
            PrintFibonacciNumbers(n - 1);
        }
    }
}
