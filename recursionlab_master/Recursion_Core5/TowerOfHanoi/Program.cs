using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the number of rings you want to try (with numbers, so 1 instead of one)");
            int n = Convert.ToInt32(Console.ReadLine());
            string start = "start";
            string aux = "aux";
            string end = "end";
            
            TowerOfHanoi(n, start, aux, end);
            Console.WriteLine($"Number of moves: {Math.Pow(2, n) - 1}");

        }
        static void TowerOfHanoi(int n, string start, string aux, string end)
        {
            if (n == 0)
            {
                return;
            }
            if (n == 1)
            {
                Console.WriteLine($"move disk {n} from {start} to {end}");
                return;
            }

            if (n >= 2)
            {
                TowerOfHanoi(n - 1, start, end, aux);
                Console.WriteLine($"move disk {n} from {start} to {end}");
                TowerOfHanoi(n - 1, aux,start, end);
            }
            
        }
    }
}
