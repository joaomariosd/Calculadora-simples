using System;

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
            
            return Val / Val2;
        }

        public override string ToString()
        {
            return "O resultado na operação " + Val + " / " + Val2 + " é: ";
        }
    }
}
