using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASequenceMoreNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}", i);
                }
                else
                {
                    Console.Write("{0}", -i);
                }
                if (i < 1000)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
