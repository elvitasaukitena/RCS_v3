using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    class Praktiskie
    {
        public void Pirmais()
        {
            int summa = 0;
            for (int i = 1; i < 10; i++)
            {
                int reiz = i * 2;
                Console.WriteLine("Summa " + reiz);
                summa = summa + reiz;
                Console.WriteLine("Summa " + summa);
            }
            Console.WriteLine("Rezultāts " + summa);
        }

        public void Otrais()
        {
            Console.WriteLine("Uzminat skaitli!");
            for (int i = 1; i < 6; i++)
            {
                int reizes = 6 - i;
                Console.WriteLine("Palikuši " + reizes + " mēģinājumi");
                string atbilde = Console.ReadLine();
                int otrs = Convert.ToInt16(atbilde);
                if (otrs == 11)
                {
                    Console.WriteLine("Uzminēji");
                    break;
                }
                else
                {
                        Console.WriteLine("Mēģiniet vēlreiz!");
                    
                    if (i == 5)
                    {

                        Console.WriteLine("Jums vairāk nav mēģinājumi!");
                    }

                }

            }
        }

        public void Tresais()
        {
            // parveidot pirmo uzd ta lai izmantotu while ciklu. 
            int summa = 0;
            int skaititajs = 1;
            while (skaititajs != 10)
            {
                int reiz = skaititajs * 2;
                summa = summa + reiz;
                skaititajs++;
            }
            Console.WriteLine("Summa ir " + summa);

        }
        public void Ceturtais()
        {
            int skaititajs = 0;
            do
            {
                Console.WriteLine("Uzminat skaitli!");
                string atbilde = Console.ReadLine();
                int otrs = Convert.ToInt16(atbilde);

                if (otrs == 11)
                {
                    Console.WriteLine("success");
                    break;
                }
                else
                {
                    if (skaititajs == 4)
                    {
                        Console.WriteLine("Mēģinājumi beigušies");
                    }
                    else
                    {


                        Console.WriteLine("Mēģini vēlreiz");
                    }
                }
                skaititajs++;
            } while (skaititajs != 5);
        }
    }

}
