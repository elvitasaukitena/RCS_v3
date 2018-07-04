using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Program
    {
        static void Main(string[] args)
        {
            CikluUzdevumi sis = new CikluUzdevumi();
            string input = "";
            while (input != "0")
            {
                Console.WriteLine("Izveleties uzdevumu");
                Console.WriteLine("1 - cikli");
                Console.WriteLine("0 - iziet");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        sis.Zvaigznite();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade!");
                        break;

                }
            }
        }

    }
}
