using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie.Werkzeuge
{
    public class Werkzeug : IBeschreibbar
    {
        public virtual string Beschreiben()
        {
            return "Hierbei handelt es sich um ein Werkzeug ";
        }
    }
}
