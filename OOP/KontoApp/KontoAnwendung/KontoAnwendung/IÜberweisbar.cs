using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    interface IÜberweisbar
    {
        bool Überweisen(decimal betrag, Konto quellkonto, Konto zielkonto);
    }
}
