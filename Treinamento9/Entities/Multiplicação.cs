using System;
using System.Globalization;

namespace Treinamento9
{
    class Multiplicação
    {
        public double Val { get; set; }
        public double Val2 { get; set; }

        public Multiplicação()
        {

        }

        public Multiplicação(double val, double val2)
        {
            Val = val;
            Val2 = val2;
        }

        public double ResultMult()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.ForegroundColor = ConsoleColor.Green;            
            double mult = Val * Val2;
            return mult;
            Console.ReadLine();
        }

        public override string ToString()
        {
            return "O resultado da operação de Multiplicação é = " + ResultMult().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
