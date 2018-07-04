using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Izveleties uzdevumu- 1, 2, 3, 4, 5 vai 6");
            string choice = Console.ReadLine();
            int ch = Convert.ToInt16(choice);
            Piemeri divi = new Piemeri();
            Praktiskie prak = new Praktiskie(); //Klases objekts

            switch (ch)
            {
                case 1:
                    prak.Pirmais();
                    break;
                case 2:
                    prak.Otrais();
                    break;
                case 3:
                    divi.Kamer();
                    break;
                case 4:
                    divi.Darit();
                    break;
                case 5:
                    prak.Tresais();
                    break;
                case 6:
                    prak.Ceturtais();
                    break;
                default:
                    Console.WriteLine("Nepareiza ievade!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
