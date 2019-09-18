using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        public enum Rechenoperationen { Addition = 1, Subtraktion = 2, Multiplikation = 3, Division = 4}

        static void Main(string[] args)
        {
            Console.Write("Bitte geben Sie eine Gleitkommazahl ein: ");
            double zahl1 = double.Parse(Console.ReadLine());
            Console.Write("Bitte geben Sie eine 2. Gleitkommazahl ein: ");
            double zahl2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Bitte geben sie die Nummer der gewünschten Operation ein: ");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");

            Rechenoperationen operation = (Rechenoperationen)int.Parse(Console.ReadLine());

            Console.WriteLine($"Ergebnis: {Berechne(zahl1, zahl2, operation)}");
            Console.ReadKey();
        }

        public static double Berechne(double zahl1, double zahl2, Rechenoperationen operation)
        {
            switch (operation)
            {
                case Rechenoperationen.Addition:
                    return zahl1 + zahl2;
                case Rechenoperationen.Subtraktion:
                    return zahl1 - zahl2;
                case Rechenoperationen.Multiplikation:
                    return zahl1 * zahl2;
                case Rechenoperationen.Division:
                    if(zahl2 == 0)
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt!");
                        return 0;
                    }
                    return zahl1 / zahl2;
                default:
                    return 0;
            }
        }
    }
}
