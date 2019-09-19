using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    class Program
    {
        public enum Operation { Einzahlen = 1, Abheben = 2 }
        static void Main(string[] args)
        {
            GiroKonto gk1 = new GiroKonto("Giro Will", 10000);

            JugendKonto jk1 = new JugendKonto("Jun Will", 500);

            Console.WriteLine("Was möchtest du machen?");
            Console.WriteLine("1: Einzahlen / 2: Abheben");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Wieviel möchtest du einzahlen?");
                    decimal betragE = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"{betragE} wurden eingezahlt");
                    Console.WriteLine($"Neuer Kontostand beträgt: {jk1.Einzahlen(betragE)}");
                    jk1.Einzahlen(betragE);
                    break;
                case 2:
                    Console.WriteLine("Wieviel möchtest du abheben?");
                    decimal betragA = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"Neuer Kontostand beträgt: {jk1.Abheben(betragA)}"); 
                    break;
                default:
                    break;
            }

            Console.WriteLine("--- PROGRAMM ENDE ---");
            Console.ReadLine();

        }
    }
}
