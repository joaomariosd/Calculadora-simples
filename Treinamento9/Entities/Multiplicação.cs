using System;

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
            return Val * Val2;
        }

        public override string ToString()
        {
            return "O resultado da operação " + Val + " * " + Val2 + " é: ";
        }
    }
}
