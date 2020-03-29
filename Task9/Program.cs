using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter two numbers \nA = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("B = ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A more B");
            }
            else
            {
                Console.WriteLine("A less B");
            }

            Console.ReadKey();
        }
    }
}
