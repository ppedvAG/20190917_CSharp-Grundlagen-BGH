using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_Inheritance
{
    public class PKW : Fahrzeug
    {
        public int StauraumVolumen { get; set; }
        public int reifendruck { get; set; }

        public PKW(string farbe, int stauraumvolumen) : base(farbe) // Aufruf des Mutter-Konstruktors
        {
            StauraumVolumen = stauraumvolumen;
            reifendruck = 3;
        }

        public override string Beschreiben()
        {
            return base.Beschreiben() + " und habe 4 Reifen";
        }

        // "Vorgabe" geerbt von Mutterklasse "Fahrzeug", mit Schlüsselwort "override" überschreiben und 
        // Logik implementieren!
        public override bool IstFahrbereit()
        {
            // Logik:
            return (reifendruck > 0);
        }
    }
}
