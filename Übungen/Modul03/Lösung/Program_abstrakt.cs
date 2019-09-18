using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaschenRechnerConsole {
    class Program {
        public enum Operation {
            Addieren,
            Substrahieren,
            Multiplizieren,
            Dividieren
        }
        static void Main(string[] args) {
            Console.WriteLine("Bitte gib eine Zahl als ersten Operanden an: ");
            double firstOperand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib eine Zahl als zweiten Operanden an: ");
            double secondOperand = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Welche Operation möchtest Du ausführen?");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Substraktion");
            Console.WriteLine("3: Multiplikation");
            Console.WriteLine("4: Division");
            int selectedOperation = Convert.ToInt32(Console.ReadLine());
            switch (selectedOperation) {
                case 1:
                    Console.WriteLine($"Ergebnis: {Berechnen(firstOperand, secondOperand, Operation.Addieren)}"); 
                    break;
                case 2:
                    Console.WriteLine($"Ergebnis: {Berechnen(firstOperand, secondOperand, Operation.Substrahieren)}");
                    break;
                case 3:
                    Console.WriteLine($"Ergebnis: {Berechnen(firstOperand, secondOperand, Operation.Multiplizieren)}");
                    break;
                case 4:
                    Console.WriteLine($"Ergebnis: {Berechnen(firstOperand, secondOperand, Operation.Dividieren)}");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        public static double Berechnen(double figOne, double figTwo, Operation operationType) {
            switch(operationType) {
                case Operation.Addieren:
                    return (double)figOne + figTwo;
                case Operation.Substrahieren:
                    return (double)figOne - figTwo;
                case Operation.Multiplizieren:
                    return (double)figOne * figTwo;
                case Operation.Dividieren:
                    return (double)figOne / figTwo;
                default:
                    break;
            }
            return 0;
        }
    }
}
