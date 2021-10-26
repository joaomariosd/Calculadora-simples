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
            Console.WriteLine("Digite a operação que deseja executar:");
            Console.Write("Soma = +, Subtração = -, Multiplicação = *, Divisão = /, Sair = s: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine();


            if (c == '+')
            {
                Soma sum = new Soma();
                Console.WriteLine(sum);


            } else if (c == '-')
            {
                Subtracao sub = new Subtracao();
                Console.WriteLine(sub);


            } else if (c == '*')
            {
                Multiplicação mult = new Multiplicação();
                Console.WriteLine(mult);


            } else if (c == '/')
            {
                Divisao div = new Divisao();
                Console.WriteLine(div);


            } else if (c == 's')
            {
                Console.WriteLine("Saindo!");

            } else
            {
                Console.WriteLine("Opção não informada! ");

            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
    }
}
