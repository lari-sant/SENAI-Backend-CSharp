using System;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            float percentual;
            float mercadoria;
            float acrescimo;

            Console.WriteLine("Digite o custo da mercadoria: ");

            mercadoria = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor do acrescimo: ");
            acrescimo = int.Parse(Console.ReadLine());

            percentual = (mercadoria/100) * acrescimo;

            Console.WriteLine("Valor total com acrescimo de " + percentual);


        }
    }
}
