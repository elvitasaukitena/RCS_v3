using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class CikluUzdevumi
    {
        public void Zvaigznite()
        {
            Console.WriteLine("Ievadiet skaitli!");
            string input = Console.ReadLine();
            int robeza = Convert.ToInt16(input);
            string zvaigzne = "";
            if(robeza <= 0)
                {
                Console.WriteLine("Kļūdaina ievade!");
            }
            else
            {
                for (int i = 0; i < robeza; i++)
                {
                    zvaigzne = zvaigzne + "*";
                    Console.WriteLine(zvaigzne);
                }
            }
            int skaititajs = 0;
            zvaigzne = "";
            while (skaititajs != robeza)
            {
                zvaigzne = zvaigzne + "*";
                skaititajs++;
            }
        }
    }
}
