using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine("n is equal to " + n);
            PrintFibonacciNumbers(n);
        }

        static int PrintFibonacciNumbers(int n)
        {
            int fibonacci = 0;
            int count = 0;
            
            if (n == 0)  return fibonacci;
            while (count < n)
            {
                if (n == 1) // 1
                {
                    fibonacci = 1;
                    break;
                }
                else if (n == 2) // 1
                {
                    fibonacci = 1;
                    break;
                }
                else if (n == 3) // 2
                {
                    fibonacci = 1 + 1;
                    break;
                }
                else // 4 = 3, 5 = 5
                {
                    int fiboNegOne = PrintFibonacciNumber(n-1);
                    int fiboNegTwo = PrintFibonacciNumber(n-2);
                    fibonacci = fiboNegOne + fiboNegTwo;
                }
                count++;
            }
            Console.WriteLine(fibonacci);
            PrintFibonacciNumbers(n - 1);
            return fibonacci;
        }
        static int PrintFibonacciNumber(int n)
        {
            int fibonacci = 0;
            int count = 0;
            if (n == 0)  return fibonacci;
            while (count < n)
            {
                if (n == 1) // 1
                {
                    fibonacci = 1;
                    break;
                }
                else if (n == 2) // 1
                {
                    fibonacci = 1;
                    break;
                }
                else if (n == 3) // 2
                {
                    fibonacci = 1 + 1;
                    break;
                }
                else // 4 = 3, 5 = 5
                {
                    int fiboNegOne = PrintFibonacciNumber(n-1);
                    int fiboNegTwo = PrintFibonacciNumber(n-2);
                    
                    fibonacci = fiboNegOne + fiboNegTwo;
                }
                count++;
            }
            return fibonacci;
        }
    }
}
