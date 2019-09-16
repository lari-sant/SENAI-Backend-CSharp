using System;

namespace atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            double passagem, dinherio_arrecadado;
            int passageiros;
            Console.WriteLine("Digite o preço da passagem R$ ");
            passagem = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de passageiros do onibus: ");
            passageiros = int.Parse(Console.ReadLine());
            dinherio_arrecadado = passagem * passageiros;
            Console.WriteLine("Foi arrecadado R$ " + dinherio_arrecadado);

        }
    }
}
