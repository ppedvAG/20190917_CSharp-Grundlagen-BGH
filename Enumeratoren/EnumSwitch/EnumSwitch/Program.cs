using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitch
{

    class Program
    {
        public enum Operation { addieren=1, substrahieren, dividieren, multiplizieren }

        static void Main(string[] args, int[] args1)
        {
            #region Enum Switch
            //Console.WriteLine("Was willst du machen? 1 addieren 2 subst 3 div 4 mul");
            //int operation = int.Parse(Console.ReadLine());

            //switch (operation)
            //{
            //    case (int)Operation.addieren:
            //        Console.WriteLine("Operation addieren wird ausgeführt");
            //        break;
            //    case (int)Operation.substrahieren:
            //        Console.WriteLine("Operation substrahieren wird ausgeführt");
            //        break;
            //    case (int)Operation.dividieren:
            //        Console.WriteLine("Operation dividieren wird ausgeführt");
            //        break;
            //    case (int)Operation.multiplizieren:
            //        Console.WriteLine("Operation multiplizieren wird ausgeführt");
            //        break;
            //    default:
            //        break;
            //}
            #endregion Enum Switch

            Console.WriteLine(Begrüßen("Peter"));

            Console.WriteLine(Addieren(5,5));

            //int[] zusummieren = new int[] { 5, 5 };

            //Console.WriteLine("Das Ergebnis ist: " + Addieren(zusummieren));

            // Dynamische Parametrisierung
            Console.WriteLine("Das Ergebnis ist: " + Addieren(5,5,10,5,6,29,102,385,92138));

            Console.WriteLine("--- ENDE ---");
            Console.ReadLine();
        }

        public static string Begrüßen(string Name)
        {
            return "Hallo " + Name;
        }

        /// <summary>
        /// Addiert zwei Integer miteinander und liefert ein Ergebniss als Integer
        /// </summary>
        /// <param name="zahl1">int, erste Zahl</param>
        /// <param name="zahl2">int, zweite Zahl</param>
        /// <returns>Summe als int</returns>
        public static int Addieren(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        //public static int Addieren(int[] zahlen)
        //{
        //    int summe = 0;
        //    foreach (int zahl in zahlen)
        //    {
        //        summe += zahl;
        //    }
        //    return summe;
        //}

        public static int Addieren(params int[] zahlen)
        {
            int summe = 0;
            foreach (int zahl in zahlen)
            {
                summe += zahl;
            }
            return summe;
        }

    }
}
