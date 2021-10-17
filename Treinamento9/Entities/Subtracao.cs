using System;

namespace Treinamento9
{
    class Subtracao
    {
        public double Val { get; set; }
        public double Val2 { get; set; }

        public Subtracao()
        {

        }

        public Subtracao(double val, double val2)
        {
            Val = val;
            Val2 = val2;
        }

        public double ResultSubtracao()
        {
            return Val - Val2;
        }

        public override string ToString()
        {
            return "O resultado da operação " + Val + " - " + Val2 + " é: ";
        }
    }
}
