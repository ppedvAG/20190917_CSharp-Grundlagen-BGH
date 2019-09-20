using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerischeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringListe = new List<string>();
            stringListe.Add("Erster String");

            Console.WriteLine(stringListe[0]);

            Console.ReadLine();
        }
    }
}
