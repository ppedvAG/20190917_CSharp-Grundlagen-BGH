using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    public class Konto
    {
        // Eigenschaften
        public string Inhaber { get; set; }
        public decimal Kontostand { get; private set; }

        // Methoden
        public decimal Einzahlen(decimal betrag)
        {
            // Logik zum Einzahlen
            this.Kontostand += betrag;
            return Kontostand;
        }
        public decimal Abheben(decimal betrag)
        {
            // Logik zum Abheben
            this.Kontostand -= betrag;
            return Kontostand;
        }

        // Konstruktor
        public Konto(string inhaber, decimal kontostand)
        {
            this.Kontostand = kontostand;
            this.Inhaber = inhaber;
        }

    }
}
