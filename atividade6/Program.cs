using System;

namespace atividade6
{
    class Program
    {
        static void Main(string[] args)
        {
            double sf, contas, sobra;

            Console.WriteLine("Digite o seu salario");
            sf = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de contas a pagar");
            contas = double.Parse(Console.ReadLine());
            sobra =  sf - contas;
            Console.WriteLine("Sobrou R$  " + sobra + " do seu salario apos pagar dividas");

        }
    }
}
