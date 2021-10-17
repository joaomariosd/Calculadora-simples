using System;
using System.Globalization;


namespace Treinamento9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Calculadora!".ToUpper());
            
            Console.WriteLine();
            Console.WriteLine("Digite a operação que deseja:");
            Console.Write("Soma = +, Subtração = -, Multiplicação = *, Divisão = /: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite o primeiro número: ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o segundo número: ");
            double val2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (c == '+')
            {
                Soma soma = new Soma(val, val2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(soma);                
                Console.WriteLine(soma.ResultSoma());


            } else if(c == '-')
            {
                Subtracao sub = new Subtracao(val, val2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(sub);                
                Console.WriteLine(sub.ResultSubtracao());

            } else if(c == '*')
            {
                Multiplicação mult = new Multiplicação(val, val2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(mult);               
                Console.WriteLine(mult.ResultMult().ToString("F2", CultureInfo.InvariantCulture));

            } else if(c == '/')
            {
                Divisao div = new Divisao(val, val2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.Write(div);               
                Console.WriteLine(div.ResultDiv().ToString("F2", CultureInfo.InvariantCulture));

            } else
            {
                Console.WriteLine("Opção não informada! ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;


            Console.ReadKey();
        }
    }
}
