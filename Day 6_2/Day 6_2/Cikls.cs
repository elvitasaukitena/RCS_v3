using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_2
{
    class Cikls
    {
        public void Piemers()
        {

            // cikli - for(tikai int), while, do..while i++ = i=i+i i-- = i=i-i
            for (int i = 0; i < 6; i++)//for(sakuma vertiba; lidz kuram ies; i+1)
            {
                Console.WriteLine("Elvita");
                if (i == 3)
                {
                    Console.WriteLine("Ir 3!!!");
                }
            }

            for (int skaititajs = 7; skaititajs > 0; skaititajs--)
            {
                Console.WriteLine("Skaitam uz otru pusi!");
            }
            Console.WriteLine("Ievadit skaitli!");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);
            for (int i = 0; i < robeza; i++)
            {
                Console.WriteLine(i);
            }

        }
        public void Faktorialis()// faktorialis no 3, ir 1+2+3
        {
            Console.WriteLine("Ievadit skaitli!");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);
            int summa = 0;
            for (int i = 1; i < robeza + 1; i++)
            {
                summa = summa + i;
            } // labs veids kā pārbaudīt vai ir pareizi
            Console.WriteLine("Faktorialis ir " + summa);
            // ja šis ir iekšā ciklā tad saskaita katru reizi, ko parbauda ciklu. 

        }
        public void Reste()
        {
            Console.WriteLine("Ievadit skaitli!");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);
            string restite = "";
            //robeza ievada cilveks, mums izvaditos tik restes, cik cilvēks ievada skaitli
            //string blabla = "ajsncj" + "acjld";

            for (int i = 0; i < robeza + 1; i++)
            {
                restite = restite + "#";
                 //input = input + "#";
            }
            Console.WriteLine(restite);
        }
    }
    
}
