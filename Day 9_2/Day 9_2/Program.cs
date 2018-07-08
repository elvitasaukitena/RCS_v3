using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkulators jauns = new Kalkulators();
            string input = "";
            while (input != "0")
            {
                Console.WriteLine("Izveleties uzdevumu");
                Console.WriteLine("1 - Saskaitīšana");
                Console.WriteLine("2 - Atņemšana");
                Console.WriteLine("3 - Reizināšana");
                Console.WriteLine("4 - Dalīšana");
                Console.WriteLine("5 - Kāpināšana");
                Console.WriteLine("0 - iziet");
                input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        double rezultats, rezultats2;
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis = Console.ReadLine();
                        rezultats = Convert.ToDouble(skaitlis);
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis2 = Console.ReadLine();
                        rezultats2 = Convert.ToDouble(skaitlis2);
                        jauns.Saskaita(rezultats, rezultats2);
                        
                        break;  
                    case "2":
                        double rezultats1, rezultats3;
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis1 = Console.ReadLine();
                        rezultats1 = Convert.ToDouble(skaitlis1);
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis3 = Console.ReadLine();
                        rezultats3 = Convert.ToDouble(skaitlis3);
                        jauns.Atnem(rezultats1, rezultats3);
                        break;
                    case "3":
                        double rezultats4, rezultats5;
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis4 = Console.ReadLine();
                        rezultats4 = Convert.ToDouble(skaitlis4);
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis5 = Console.ReadLine();
                        rezultats5 = Convert.ToDouble(skaitlis5);
                        jauns.Reizina(rezultats4, rezultats5);
                        break;
                    case "4":
                        double rezultats6, rezultats7;
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis6 = Console.ReadLine();
                        rezultats6 = Convert.ToDouble(skaitlis6);
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis7 = Console.ReadLine();
                        rezultats7 = Convert.ToDouble(skaitlis7);
                        jauns.Dala(rezultats6, rezultats7);
                        break;
                    case "5":
                        double rezultats8, rezultats9;
                        Console.WriteLine("Ievadat skaitli");
                        string skaitlis8 = Console.ReadLine();
                        rezultats8 = Convert.ToDouble(skaitlis8);
                        Console.WriteLine("Ievadat skaitli, kurā pakāpē kāpināt");
                        string skaitlis9 = Console.ReadLine();
                        rezultats9 = Convert.ToDouble(skaitlis9);
                        jauns.Kapina(rezultats8, rezultats9);
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
