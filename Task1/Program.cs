using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0,t = 10000;
            int mainValue = 0;

            Console.Write("Enter a five digit number : ");
            mainValue = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (mainValue < 10000 || mainValue >=100000)
            {
                Console.WriteLine("ERROR :: the entered number is not five-digit");
                Console.ReadKey();
                return;
            }
            
            for(int i =1;i<=5;i++)
            {
                result = mainValue/t % 10;
                Console.WriteLine("{1} number is equal to  {0}", result, i);
                t = t / 10;
            }

            Console.ReadKey();
        }
    }
}
