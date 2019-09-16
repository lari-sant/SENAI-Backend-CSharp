using System;

namespace atividade5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sf, tv, comissao, rf;
            string nome; 
            Console.WriteLine("digite o seu nome ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu salario fixo");
            sf = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas em reais");
            tv = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua comissão");
            comissao = double.Parse(Console.ReadLine());
            rf= sf + (comissao * tv);
            Console.WriteLine(nome + "ganha de salario mensal:R$ " + sf + " e o seu salario final com comissão é: R$ " + rf);
            
        } 
    }
}
