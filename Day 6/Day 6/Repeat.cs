using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    class Repeat
    {
        public void Izvade()
        {
            Console.WriteLine("Lūdzu, ievadiet skaitli!");
            string ievade = Console.ReadLine();
            int viens = Convert.ToInt16(ievade);
            string output = Sharp(viens);
            Console.WriteLine("Skaitlis ir " + output);
        }
        private string Sharp(int a)
        {
            string result = "";
            if (a > 5)
            {
                result = "##";
            }
            else
            {
                result = "#";
            }
            return result; 
        }
    }
}
