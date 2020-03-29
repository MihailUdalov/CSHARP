using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters, kilometers;

            Console.Write("Введите количество метров : ");
            meters = double.Parse(Console.ReadLine());

            kilometers = meters / 1000;

            Console.Write("{0} метров будет {1} километров ", meters,kilometers);

            Console.ReadKey();


        }
    }
}
