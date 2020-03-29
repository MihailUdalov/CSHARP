using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
      
            Console.Write('\u2554');
            for(int i =0;i<=6;i++)
            {
                Console.Write('\u2566');
            }
            Console.Write('\u2557');

            Console.WriteLine();

            Console.Write('\u255A');
            for (int i = 0; i <= 6; i++)
            {
                Console.Write('\u2569');
            }
            Console.Write('\u255D');

            Console.ReadKey();
        }
    }
}
