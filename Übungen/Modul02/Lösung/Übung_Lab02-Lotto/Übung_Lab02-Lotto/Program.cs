using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung_Lab02_Lotto {
    class Program {
        static void Main(string[] args) {

            // Initialisierung der benötigten Objekte
            // Zufallszahlen-Generator
            Random generator = new Random();

            // Jeweils ein Array für 3 Zufallszahlen und 3 Benutzerzahlen
            int[] zufallsZahlen = new int[3];
            int[] benutzerZahlen = new int[3];

            // Initialisierung einer Variablen für die eigentliche Zufallszahl
            int zufallszahl;

            // Zähler-Variable
            int richtig = 0;

            // Drei mal Benutzereingabe einlesen
            Console.Write("Bitte eine Zahl zwischen 1 und 10 eingeben: ");
            // Jeweils Dem Array hinzufügen ->> Keine Prüfung auf doppelte Eingabe
            benutzerZahlen[0] = int.Parse(Console.ReadLine());

            Console.Write("Bitte eine Zahl weitere zwischen 1 und 10 eingeben: ");
            benutzerZahlen[1] = int.Parse(Console.ReadLine());

            Console.Write("Bitte eine letzte Zahl zwischen 1 und 10 eingeben: ");
            benutzerZahlen[2] = int.Parse(Console.ReadLine());

            // Drei mal durchschleifen (Array.Length = 3)
            for (int i = 0; i < zufallsZahlen.Length; i++) {
                // zufallszahl "nullen"
                zufallszahl = 0;
                // beim ersten Durchlauf kann die Zufallszahl noch nicht im Array enthalten sein
                do {
                    // deswegen generieren und...
                    zufallszahl = generator.Next(1, 11);
                } while (zufallsZahlen.Contains(zufallszahl)); // wenn unser Array die soeben generierte Zufallszahl bereits beinhaltet
                // ergibt der Bedingungs-Ausdruck im Schleifen-Fuß true, und somit wird erneut eine Zufallszahl generiert.

                // ...dem Array hinzufügen
                zufallsZahlen[i] = zufallszahl;

                // Ausgabe der ersten Gewinnzahl (+1, weil i mit 0 beginnt.)
                Console.WriteLine($"{i+1}. Gewinnzahl: {zufallszahl}");
                // Innerhalb der Schleife prüfen, ob eine der angegebenen Zahlen des Benutzers (foreach) der aktuellen Zufallszahl entspricht
                foreach(int zahl in benutzerZahlen) {
                    if(zufallszahl == zahl) {
                        // wenn ja, die Anzahl der richtig getippten erhöhen
                        richtig++;
                    }
                }
            }
            Console.WriteLine($"Du hast {richtig} Zahl(en) richtig getippt!");
            Console.ReadLine();
        }
    }
}
