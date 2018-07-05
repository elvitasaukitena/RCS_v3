using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9
{
    class Piemeri
    {
        public void Klase()
        {
            string[] galdi = new string[12];
            int robeza = galdi.Length;
            //12 vietas ievadit tukss vai aiznemts galds. tuksa vieta 0, 
            // string[] masivs = string[12] cilveka vards vai 0. izvadit masivu, extra ievadit tikai neaiznemtas vietas. 

            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine("ievadiet vardu vai 0, ja galds ir tukss?");
                galdi[i] = Console.ReadLine();
            }

            for (int i = 0; i < robeza; i++)
            {
                if (galdi[i] != "0")
                {
                    Console.WriteLine("Pie galda sēž: " + galdi[i]);
                }
                else
                {
                    Console.WriteLine("Galds ir tukšs.");
                }
                if (i == robeza-1)
                {
                    Console.WriteLine("_______________");
                }
            }


        }

    }

}
