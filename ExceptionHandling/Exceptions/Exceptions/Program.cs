using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int b = 0;

        START:

            Console.WriteLine("Zahl eingeben");

            // Custom
            //throw new CustomException("Hier ist ein Fehler passiert");

            //Diese Zeile
            try
            {
                i = int.Parse(Console.ReadLine());

                //try
                //{
                //    Console.WriteLine("Weitere Zahl eingeben");
                //    b = int.Parse(Console.ReadLine());
                    
                //} catch (Exception ex)
                //{
                //    Console.WriteLine("Innere Exception");
                //    Console.WriteLine(ex.Message);
                //    Console.WriteLine(ex.StackTrace);
                //    throw new CustomException("Hier ist ein Fehler passiert");
                //    goto START;
                //}

                // Finally-Block wird immer ausgeführt, egal ob Ausnahme oder nicht
                //finally
                //{
                //    Console.WriteLine("ok");
                    
                //}

            } catch (Exception ex)
            {
                Console.WriteLine("Äußere Exception");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new CustomException("Hier ist ein Fehler passiert");

            } finally
            {
                i = 0;
                b = 0;
            }


            Console.WriteLine("--- ENDE PROGRAMM ---");
            Console.ReadLine();

        }
    }
}
