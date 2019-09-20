using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie.Werkzeuge
{
    class Kreissucher : Werkzeug
    {
        //
        public override string Beschreiben()
        {
            return base.Beschreiben() + "vom Typen Kreissucher";
        }
    }
}
