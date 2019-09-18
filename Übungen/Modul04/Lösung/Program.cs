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
            Konto k1 = new Konto("Daniel Will", 10000);

            Console.WriteLine("Was möchtest du machen?");
            Console.WriteLine("1: Einzahlen / 2: Abheben");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Wieviel möchtest du einzahlen?");
                    decimal betragE = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"{betragE} wurden eingezahlt");
                    Console.WriteLine($"Neuer Kontostand beträgt: {k1.Einzahlen(betragE)}");
                    k1.Einzahlen(betragE);
                    break;
                case 2:
                    Console.WriteLine("Wieviel möchtest du abheben?");
                    decimal betragA = decimal.Parse(Console.ReadLine());
                    Console.WriteLine($"{betragA} wurden abgehoben");
                    Console.WriteLine($"Neuer Kontostand beträgt: {k1.Abheben(betragA)}"); 
                    break;
                default:
                    break;
            }

            Console.WriteLine("--- PROGRAMM ENDE ---");
            Console.ReadLine();

        }
    }
}
