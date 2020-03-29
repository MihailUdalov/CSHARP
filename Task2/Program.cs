using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, f;
            long x=0;

            Console.Write("A = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("B = ");
            b = int.Parse(Console.ReadLine());

            Console.Write("F = ");
            f = int.Parse(Console.ReadLine());
            
            x = (a + b - f / a) + f * a * a - (a + b);

            Console.Write("Calculated by the formula : x = (a + b - f / a) + f * a * a - (a + b) \nX = {0} ", x);

            Console.ReadKey();
        }
    }
}
