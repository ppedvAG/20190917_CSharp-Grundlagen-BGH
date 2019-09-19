using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_Inheritance
{
    class Motorrad : Fahrzeug
    {
        public Motorrad(string farbe) : base(farbe)
        {

        }

        public override string Beschreiben()
        {
            return base.Beschreiben() + " und habe zwei Reifen";
        }

        public override bool IstFahrbereit()
        {
            throw new NotImplementedException();
        }
    }
}
