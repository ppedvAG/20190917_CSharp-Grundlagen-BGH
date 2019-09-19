using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_Inheritance
{
    // Beinhaltet eine Klasse eine abstrakte Methode, muss die Klasse ebenfalls mit abstract marktiert sein
    public abstract class Fahrzeug
    {
        // Vorgabe für Kindklassen, "abstract"-Methode dient als "Vorgabe", nur Signatur, keine Logik-Implementierung
       public abstract bool IstFahrbereit();
       public string Farbe { get; set; }

        public virtual string Beschreiben()
        {
            return "Ich bin ein Fahrzeug...";
        }

        public Fahrzeug(string farbe)
        {
            Farbe = farbe;
        }

    }
}
