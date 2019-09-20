using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    public class JugendKonto : Konto
    {
        // Konstruktor, mit Konstruktor-Aufruf aus Basis-Klasse "Konto"
        public JugendKonto(string Inhaber, decimal Kontostand) : base(Inhaber, Kontostand)
        {

        }

        public override decimal Abheben(decimal betrag)
        {
            if (!(betrag > 50) && !(betrag > Kontostand))
            {
                return base.Abheben(betrag);
            } else
            {
                Console.WriteLine($"Betrag {betrag},- übersteigt Limit von 50,-");
            }
            return Kontostand;
        }


        public override bool Überweisen(decimal betrag, Konto quellkonto, Konto zielkonto)
        {
            try
            {
                if (!(betrag > 100))
                {
                    quellkonto.Kontostand -= betrag;
                    zielkonto.Kontostand += betrag;
                    return true;
                } else
                {
                    throw new LimitException("Überweisungslimit von 100,- wurde überschritten!");
                }
            } catch (LimitException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return false;
            }
        }

    }
}
