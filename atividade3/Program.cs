using System;

namespace atividade3
{
    class Program
    {
        static void Main(string[] args)   
        {
            float salariofixo;
            int totalv;
            float salariototal;
            float total;
            float comissao;
        

            Console.WriteLine("Escreva seu salario fixo:");
            salariofixo = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva seu total de vendas: ");
            totalv = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o percentual de comissao ");
            comissao = int.Parse(Console.ReadLine());
            total = (salariofixo + totalv) *comissao/100;
            salariototal = salariofixo + total; 
            Console.WriteLine("O salario total é " + salariototal);



        }
    }
}
