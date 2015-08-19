using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int a ;
            Console.WriteLine("Vavedete chislo");
            string SomeValue = Console.ReadLine();
            a = int.Parse(SomeValue);

            Console.WriteLine(Math.Sqrt(a));
        }
    }
}
