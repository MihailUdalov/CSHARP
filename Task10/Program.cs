using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter two numbers \nA = ");
            a = int.Parse(Console.ReadLine());

            Console.Write("B = ");
            b = int.Parse(Console.ReadLine());

            Console.Write("C = ");
            c = int.Parse(Console.ReadLine());

            if(c%3 == 0|| b==2|| a%2 !=0)
            {
                c = c + 9;
                b = c + a;
                a = a + 3;
            }

            Console.WriteLine("A = {1}, B = {2}, C = {0}", c, b, a);
            Console.ReadKey();
        }
    }
}
