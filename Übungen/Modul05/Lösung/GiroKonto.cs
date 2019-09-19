using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    public class GiroKonto : Konto
    {
        // Konstruktor, mit Konstruktor-Aufruf aus Basis-Klasse "Konto"
        public GiroKonto(string Inhaber, decimal Kontostand) : base(Inhaber, Kontostand)
        {
            // Kontruktorlogik
            // Initialisierung mit Daten
        }
        public override decimal Einzahlen(decimal betrag)
        {
            // Logik zum Einzahlen
            // Auf den Einzahl-Betrag eines GiroKontos gibt es kein Limit
            base.Einzahlen(betrag);
            return Kontostand;
        }
        public override decimal Abheben(decimal betrag)
        {
            // Spezialisierte Logik zum Abheben (nicht mehr als 50€)
            Console.WriteLine($"Abhebung über {betrag},- getätigt von GiroKonto.");
            return base.Abheben(betrag);
        }
    }
}
