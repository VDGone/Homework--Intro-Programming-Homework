using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateBirthday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete rojdena (data dd/mm/yyyy)");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime currentDate = DateTime.Now;

            int age = currentDate.Year - birthday.Year;

            if (birthday.Month > currentDate.Month) 
            {
                age = age - 1;
            }
            if (birthday.Month == currentDate.Month)
            {
                if (birthday.Day > currentDate.Day) 
                {
                    age = age - 1;
                }
            }

            Console.WriteLine("Vie ste na " + age + "g.");
            Console.WriteLine("Sled 10 godini shte ste na " + (age + 10) +"g.");
        }
    }
}
