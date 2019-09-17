using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2 {
    class Program {
        static void Main(string[] args) {

            #region Arrays und Schleifen
            //int zahl = 5;
            // Array mit fester Größe
            //int[] ZAHLEN = new int[5];

            //ZAHLEN[0] = 1;
            //ZAHLEN[1] = 2;
            //ZAHLEN[2] = 3;
            //ZAHLEN[3] = 4;
            //ZAHLEN[4] = 5;

            //string string1 = "Erster String";
            //string string2 = "Zweiter String";

            // Array-Initialisierer
            //string[] stringArray = new string[] {
            //    "String 1",
            //    "String 2",
            //    "Das ist ein längerer String",
            //    string1,
            //    string2
            //};

            // mehrdimensional
            //int[,] array2d = new int[2, 2];

            //foreach(var element in stringArray) {
            //    Console.WriteLine($"Inhalt: {element}");
            //}

            //for(int i = 0; i < stringArray.Length; i++) {
            //    Console.WriteLine($"{i}. Index: {stringArray[i]}");
            //}

            //Console.Write("Zahl eingeben: ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("Weitere Zahl eingeben: ");
            //int b = int.Parse(Console.ReadLine());

            //do {
            //    bool abbrechen = false;
            //    Console.WriteLine("ok");
            //    for (int i = 0; i <= 3; i++) {
            //        Console.WriteLine($"In der For-Schleife, {i}ter Durchlauf.");
            //        if (i == 3) {
            //            abbrechen = true;
            //        }
            //        a = 100;
            //    }
            //    if (abbrechen)
            //        break;
            //} while (a + b == 10);

            //Console.Write("Zahl eingeben");
            //Console.Write("Weitere Zahl eingeben");
            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());


            //while (c + d == 10) {
            //    Console.WriteLine("ok");
            //}


            //int[,,,,,,,,,,,]

            //Console.WriteLine($"Länge des Arrays: {ZAHLEN.Length} ");
            //Console.WriteLine($"Länge des Arrays: {stringArray.Length}");

            //Console.WriteLine($"Wert am 0. Index: {stringArray[0]}"); 

            //int[] einZahlenArray = new int[] {
            //    1,2,3,4,5
            //};

            //string[] einStringArray = new string[] {
            //    "Hallo","Welt","Wie","gehts"
            //};

            //if (einZahlenArray.Contains(5)) {
            //    int variable1 = 10;
            //    variable = 50;
            //    Console.WriteLine("Zahl 5 ist enthalten");
            //}

            ////Console.WriteLine(variable1);

            //if (einStringArray.Contains("Welt")) {
            //    Console.WriteLine("Welt ist enthalten");
            //}
            #endregion Arrays und Schleifen

            #region Zahlenraten

            Random generator = new Random();
            int zufallszahl = generator.Next(1, 10);
            int benutzerEingabe;
            int Versuchsanzahl = 0;

            do {
                Console.Write("Bitte eine Zahl eingeben: ");
                benutzerEingabe = int.Parse(Console.ReadLine());
                Versuchsanzahl++;
            } while (zufallszahl != benutzerEingabe);

            Console.WriteLine($"Die Zufallszahl war {zufallszahl}, Du hast {Versuchsanzahl} Versuche gebraucht.");




            #endregion

            Console.WriteLine("ENDE");
            Console.ReadLine();
        }
    }
}
