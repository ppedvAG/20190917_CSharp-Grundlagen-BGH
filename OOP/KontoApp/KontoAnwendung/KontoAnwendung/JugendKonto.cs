﻿using System;
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
            if(!(betrag > 50) && !(betrag > Kontostand))
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
            if(betrag <= 100)
            {
                return base.Überweisen(betrag, quellkonto, zielkonto);
            } else
            {
                Console.WriteLine("Überweisungslimit von 100,- wurde überschritten!");
                return false;
            }
            
        }

    }
}
