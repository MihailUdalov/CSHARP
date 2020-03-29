using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;

            Console.Write("Enter a lowercase letter ");
            a = char.Parse(Console.ReadLine());

            a = char.ToUpper(a);

            Console.WriteLine("The letter in upper case {0} ", a);
            Console.ReadKey();
        }
    }
}
