using System;
using System.Globalization;

namespace Treinamento9
{
    class Soma
    {
        public double Val { get; set; }
        public double Val2 { get; set; }

        public Soma()
        {

        }

        public Soma(double val, double val2)
        {
            Val = val;
            Val2 = val2;
        }

        public double ResultSoma()
        {
            Console.Write("Digite o primeiro número: ");
            Val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            Val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            Console.ForegroundColor = ConsoleColor.Green;            
            double sum = Val + Val2;
            return sum;
            Console.ReadLine();
        }

        public override string ToString()
        {
            return "O resultado da operação de Soma é = " + ResultSoma();
        }
    }
}
