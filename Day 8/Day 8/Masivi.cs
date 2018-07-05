using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8
{
    class Masivi
    {
        public void IzvaditMasivu()
        {
            int[] PiemeraMasivs = new int[5];

            PiemeraMasivs[0] = 4;
            PiemeraMasivs[1] = 99;
            PiemeraMasivs[2] = 9;
            PiemeraMasivs[3] = 6567;
            PiemeraMasivs[4] = 567;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(PiemeraMasivs[i]);
            }

            string[] StringMasivs = new string[5];
            string viens = "";
            for (int i = 0; i < 5; i++)
            {
                viens = viens + "*";
                StringMasivs[i] = viens;
            }
            /*StringMasivs[0] = "*";
            StringMasivs[1] = "**";
            StringMasivs[2] = "***";
            StringMasivs[3] = "****";
            StringMasivs[4] = "*****";*/

            // katra elementa vertibu pieskir cikla
            string abs = StringMasivs[3];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(StringMasivs[i]);
            }
            for (int i = 4; i > -1; i--) //var ari >=0
            {
                Console.WriteLine(StringMasivs[i]);
            }
        }
    }
}
