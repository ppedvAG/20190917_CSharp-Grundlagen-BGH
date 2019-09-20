using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontoAnwendung
{
    public class LimitException : Exception
    {
        public LimitException(string message) : base(message)
        {
            //
        }
    }
}
