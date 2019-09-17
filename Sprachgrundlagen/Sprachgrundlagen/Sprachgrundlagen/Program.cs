using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sprachgrundlagen {
    class Program {
        static void Main(string[] args) {

            #region Ausgabe / Eingabe
            // Ausgabe von Daten
            //Console.WriteLine("Hallo zusammen!");

            //Console.WriteLine("Bitte Name:" );

            //string Name = Console.ReadLine();

            //Console.WriteLine(Name);

            //Console.WriteLine("Hallo " + Name);
            //Console.WriteLine("Hallo {0}", Name);
            //Console.WriteLine($"Hallo {Name}");
            #endregion Ausgabe / Eingabe

            #region Typisierung

            //var EineVariable = 3.00M;
            //string StringVariable;
            //int ZahlenVariable; // Standard: Int32
            //long LongVariable; // Long = Int64
            //double DoubleVariable; // Gleitkomma
            //decimal DecimalVariable; // Gleitkomme, höchste Präzision
            //char CharVariable; // einzelner Charakter

            //Console.WriteLine($"Datentyp von EineVariable: {EineVariable.GetType()}");

            #endregion Typisierung

            #region Konvertierung (Casting)

            //int alter = 20;

            //Console.WriteLine("Bitte Alter angeben");

            //// Explizie Umwandlung String -> Int
            //int inputAlter = int.Parse(Console.ReadLine());

            //// TryParse-Methode an int
            //// out-Variable deklarieren (Initialisierung nicht nötig)
            //int outputAlter;
            //// Extrahieren des INTs aus der Eingabe mit Rückgabewert ob erfolgreich oder nicht
            //bool  result = int.TryParse(Console.ReadLine(), out outputAlter);

            //// Implizite Umwandlung Int -> String
            //string inputAlterString = "Du bist" + alter;

            //int einInteger = 10;
            //double einDouble = 4.00;

            //// ungenau zu genau -> implizit
            //double doubleWert = einInteger;

            //// genau zu ungenau -> explizit! (Informations-Verlust)
            //int integerWert = Convert.ToInt32(einDouble);
            //Console.WriteLine($"Du bist also {inputAlter} Jahre alt.");
            #endregion Konvertierung (Casting)

            #region Mathematische Operatoren

            //Console.WriteLine("Zahl eingeben: ");
            //int zahl1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Weitere Zahl eingeben: ");
            //int zahl2 = int.Parse(Console.ReadLine());

            //if (zahl1 + zahl2 > 10) {
            //    Console.WriteLine("Die Summe ist größer als 10");
            //}

            #endregion Mathematische Operatoren

            #region Logische Operatoren + Vergleichsoperatoren

            Console.WriteLine("Wie alt bist du?");
            int eingabe = int.Parse(Console.ReadLine());

            Console.WriteLine("Wie heißt du?");
            string name = Console.ReadLine();


            if (eingabe < 18) {
                Console.WriteLine("Das darfst du leider nicht");
            } else if (eingabe >= 18 && name == "Daniel") { // Vergleichsoperator >= , Logischer Operator "UND" -> &&
                                                            // Bit-Weise (verunden) -> &
                Console.WriteLine($"ok {name}, das passt.");
            } else {
                Console.WriteLine($"Du bist zwar alt genug, aber du bist nicht Daniel");
            }

            #endregion Logische Operatoren

            Console.WriteLine("--- ENDE PROGRAMM ---");
            Console.ReadLine();
        }
    }
}
