using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void PrintTriangularNumbers(int n)
        {
            Console.WriteLine("0");
            PrintTriangularNumbers(n - 1);
        }
    }
}
