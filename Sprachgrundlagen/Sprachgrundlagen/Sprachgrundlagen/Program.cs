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
            Console.WriteLine("Hallo zusammen!");

            Console.WriteLine("Bitte Name:" );

            string Name = Console.ReadLine();

            Console.WriteLine(Name);

            Console.WriteLine("Hallo " + Name);
            Console.WriteLine("Hallo {0}", Name);
            Console.WriteLine($"Hallo {Name}");
            #endregion Ausgabe / Eingabe


            Console.WriteLine("--- ENDE PROGRAMM ---");
            Console.ReadLine();
        }
    }
}
