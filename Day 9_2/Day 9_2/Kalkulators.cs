using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_2
{
    class Kalkulators
    {
        public double Saskaita(double a, double b)
        {
            double result = a;
            result = a + b;
            Console.WriteLine("Rezultāts ir " + result);
            return result;
        }   

        public double Atnem(double a, double b)
        {
            double result = a;
            result = a - b;
            Console.WriteLine("Rezultāts ir " + result);
            return result;
        }
        public double Reizina(double a, double b)
        {
            double result = a;
            result = a * b;
            Console.WriteLine("Rezultāts ir " + result);
            return result;
        }
        public double Dala(double a, double b)
        {
            double result = a;
            result = a / b;
            Console.WriteLine("Rezultāts ir " + result);
            return result;
        }
        public double Kapina(double a, double b)
        {
            double summa = 0;
            for (int i = 0; i < 1; i++)
            {
                summa = a * a;
                summa = summa * b;
                Console.WriteLine("Rezultāts ir " + summa);

            }
            Console.WriteLine("Rezultāts " + summa);
            return summa;
        }
    }
}
