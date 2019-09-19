using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul05_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fahrzeug fz1 = new Fahrzeug("gelb");
            PKW pkw1 = new PKW("rot", 50);
            Motorrad m1 = new Motorrad("schwarz");




            Console.WriteLine(fz1.Beschreiben());

            Console.WriteLine(pkw1.Beschreiben());

            Console.WriteLine(m1.Beschreiben());

            //Console.WriteLine($"Fahrzeugfarbe: {fz1.Farbe}");
            //Console.WriteLine($"PKW-Farbe: {pkw1.Farbe}");


            Console.ReadLine();
        }
    }
}
