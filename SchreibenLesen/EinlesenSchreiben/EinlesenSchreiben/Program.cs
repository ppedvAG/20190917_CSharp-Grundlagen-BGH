using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EinlesenSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {

            //string text = File.ReadAllText(@"C:\Users\dw2\Desktop\hallowelt.txt");
            //Console.WriteLine(text);
            StreamReader streamreaderObjekt = new StreamReader(@"C:\Users\dw2\Desktop\hallowelt.txt");

            while (!streamreaderObjekt.EndOfStream)
            {
                Console.WriteLine(streamreaderObjekt.ReadLine());
            }

            streamreaderObjekt.Close();


            string dateipfad = @"C:\Users\dw2\Desktop\hallowelt.txt";

            //sw.WriteLine("Aus dem Programm geschriebener Text");
            //sw.WriteAsync("Test WriteAsync");

            //StreamWriter sw = new StreamWriter(@"C:\Users\dw2\Desktop\hallowelt.txt");

            StreamReader sr = new StreamReader(dateipfad);
            while(!sr.EndOfStream)
            {
                sr.ReadLine();
            }

            sr.Close();

            using (StreamWriter sw = File.AppendText(dateipfad))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine($"Zeile {i}");
                }

            }



            //sw.Close();


            Console.WriteLine("-- - ENDE ---");
            Console.ReadLine();

        }
    }
}
