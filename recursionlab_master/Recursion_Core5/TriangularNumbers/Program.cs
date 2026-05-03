using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Console.WriteLine($"n is equal to {n}");
            PrintTriangularNumbers(n);
        }

        static int PrintTriangularNumbers(int n)
        {
            int triangNumber = n;
            int tirangCarry = 0;
            int Triangular = 0;
            if (n == 0) return Triangular;
            while (triangNumber != 0)
            {
                tirangCarry += triangNumber;
                triangNumber--;
            }
            Triangular = tirangCarry;
            Console.WriteLine(Triangular);
            PrintTriangularNumbers(n - 1);
            return Triangular;
        }
    }
}
