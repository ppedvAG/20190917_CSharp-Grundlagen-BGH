using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    public abstract class Konto : IÜberweisbar
    {
        // Eigenschaften
        public string Inhaber { get; set; }
        public decimal Kontostand { get; set; }

        // Methoden
        public virtual decimal Einzahlen(decimal betrag)
        {
            // Logik zum Einzahlen
            // Auf den Einzahl-Betrag eines GiroKontos gibt es kein Limit
            this.Kontostand += betrag;
            return Kontostand;
        }
        public virtual decimal Abheben(decimal betrag)
        {
            // Logik zum Abheben
            // Der Abhebe-Betrag ist bei einem GiroKonto nicht limitiert
            this.Kontostand -= betrag;
            return Kontostand;
        }

        public virtual bool Überweisen(decimal betrag, Konto quellkonto, Konto zielkonto)
        {
                zielkonto.Einzahlen(betrag);            
                return true;
        }

        // Konstruktor
        public Konto(string inhaber, decimal kontostand)
        {
            this.Kontostand = kontostand;
            this.Inhaber = inhaber;
        }

    }
}
