using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KontoAnwendung
{
    class Program
    {
        public enum Operation { Einzahlen = 1, Abheben = 2 }
        static void Main(string[] args)
        {
            GiroKonto gk1 = new GiroKonto("Giro Will", 10000);

            JugendKonto jk1 = new JugendKonto("Jun Will", 500);

            #region Generics - List
            // Erstellen einer Liste, welche nur Konten beinhalten darf
            // Syntax: List<T> <- T = (Daten)Typ des aufzunehmenden Elementes
            List<Konto> KontoListe = new List<Konto>();

            // Hinzufügen von Objekten vom Typ Konto
            KontoListe.Add(gk1);
            KontoListe.Add(jk1);
            KontoListe.Add(new GiroKonto("Neuer Inhaber", 5000));


            Console.WriteLine(KontoListe[1].Inhaber);

            // Iteration der Kontoliste
            foreach (Konto konto in KontoListe)
            {
                // Ausgabe des Inhabers
                Console.WriteLine($"Konto-Inhaber: {konto.Inhaber} " );
            }

            KontoListe.Remove(gk1);

            Console.WriteLine(Environment.NewLine);
            foreach (Konto konto in KontoListe)
            {
                // Ausgabe des Inhabers
                Console.WriteLine($"Konto-Inhaber: {konto.Inhaber} ");
            }
        #endregion Generics - List


        START:

            Console.WriteLine("Was möchtest du machen?");
            Console.WriteLine("1: Einzahlen / 2: Abheben / 3: Überweisen");

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
                case 3:
                    Console.WriteLine("Wieviel möchtest du überweisen?");
                    decimal betragÜ = decimal.Parse(Console.ReadLine());
                    jk1.Überweisen(betragÜ, jk1, gk1);
                    Console.WriteLine($"Kontostand Jugendkonto (Quell): {jk1.Kontostand}, Kontostand Girokonto (Ziel): {gk1.Kontostand}");
                    break;
                default:
                    break;
            }

            goto START;
            Console.WriteLine("--- PROGRAMM ENDE ---");
            Console.ReadLine();

        }
    }
}
