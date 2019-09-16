using System;

namespace atividade4
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, conversao;

            Console.WriteLine("Digite o valor em reais ");
            real = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do dolar no momento");
            dolar = double.Parse(Console.ReadLine());
            conversao = real / dolar;
            Console.WriteLine("O valor da conversão é: " + conversao);


        }
    }
}
