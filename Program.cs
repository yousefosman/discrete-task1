using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static bool Isperfect(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0) sum = sum + i;
            }
            if (sum == number) return true;
            return false;
        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Write("please enter n1 : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("please enter n2 :");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            for (int i = x; i <= y; i++)
            {
                if (Isperfect(i)) Console.Write(" {0} ", i);

            }
            Console.ReadKey();
        }
    }
}
