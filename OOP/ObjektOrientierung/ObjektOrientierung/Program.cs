using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektOrientierung
{
    class Program
    {
        static void Main(string[] args)
        {
            #region werkzeug loop
            //List<Werkzeug> werkzeugListe = new List<Werkzeug>();

            //// input: anzahl Werkzeuge -> Anzahl der Objekte in Task
            //int anzahl = 10;

            //// input Werkzeug-Typ -> Bezeichnung des Objektes in Task

            //for(int i = 0; i <= anzahl; i++)
            //{
            //    werkzeugListe.Add(new Werkzeug()
            //    {
            //        WerkzeugTyp = "Kreissucher"
            //    });
            //}

            //foreach(Werkzeug werkzeug in werkzeugListe)
            //{
            //    if(werkzeug.Bewertung)
            //    {
            //        // setze grün
            //    } else
            //    {
            //        // setze rot
            //    }

            #endregion werkzeug loop

            Werkzeug werkzeugVariable = new Werkzeug("Kreissucher");

            Werkzeug w2 = new Werkzeug("Kreissucher", 10);

            Console.WriteLine("Typ von Werkzeug: " + werkzeugVariable.WerkzeugTyp);

            Console.ReadLine();

        }
    }
}
