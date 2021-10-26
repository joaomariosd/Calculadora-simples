using System;
using System.Globalization;

namespace Treinamento9
{
    class Divisao
    {
        public double Val { get; set; }
        public double Val2 { get; set; }

        public Divisao()
        {

        }

        public Divisao(double val, double val2)
        {
            Val = val;
            Val2 = val2;
        }

        public double ResultDiv()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.ForegroundColor = ConsoleColor.Green;            
            double div = Val / Val2;
            return div;
            Console.ReadLine();
        }

        public override string ToString()
        {
            return "O resultado da operação  de divisão é = " + ResultDiv().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
