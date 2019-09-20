using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polymorphie.Werkzeuge;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Werkzeug> werkzeugListe = new List<Werkzeug>()
            {
                new Kreissucher(),
                new Kantenantaster()
            };

            foreach(Werkzeug werkzeug in werkzeugListe)
            {
                Console.WriteLine(werkzeug.Beschreiben());
            }
            Console.ReadLine();
        }
    }
}
