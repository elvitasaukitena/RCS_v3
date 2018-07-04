using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Piemeri
    {
        public void Kamer()
        {
            string ievade = "";
            int skaititajs = 1;
            while (ievade != "")
            {
                Console.WriteLine("Uzraksti kaut ko!");
                ievade = Console.ReadLine();
                Console.WriteLine("Mēs esam iteracija nr. " + skaititajs);
                skaititajs++;//skaititajs = skaititajs +1
                Console.WriteLine("Vēl esam ciklā!");
            }
            Console.WriteLine("Jau izgajam ārā!");
        }
        public void Darit()
        {
            string ievade = "";
            int skaititajs = 0;

            do
            {
                    Console.WriteLine("Uzraksti kaut ko!");
                    ievade = Console.ReadLine();
                    Console.WriteLine("Mēs esam iteracija nr. " + skaititajs);
                    skaititajs++;//skaititajs = skaititajs +1
                    Console.WriteLine("Vēl esam ciklā!");
                
            } while (ievade != "");
            Console.WriteLine("Jau izgajam ārā!");
        }

    }
}
