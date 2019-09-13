using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
         // somente declaramos, sem atribuir valor
         int num1 = 2;

         // declaramos atribuindo valor  
         int num2= 5;

        //declaramos diversas variaveis do mesmo tipo
         int num3, num4, num5;
         
         //variavel do tipo real
         float media;

         //variavel tipo logico(booleana)
         bool resultado = false;

         // variavel do tipo texto(caracteres)
         string nomeAluno; 


         Console.WriteLine();
         // Escreve em uma linha quebrando-a
         Console.WriteLine("Bem vindos à nossa primeira apliacação");

         // Continua escrevendo na mesma linha 
         Console.Write("Digite");
         Console.Write(" seu nome:");
         
         // captura o dado digitado pelo usuario e salvo na variavel
         nomeAluno = Console.ReadLine();

         //Concatenação 
         Console.WriteLine(nomeAluno + ", Agora digite sua primeira nota:");

         // Converto o texto capturado para o tipo inteiro
         num3 = int.Parse(Console.ReadLine());

         //Interpolação
         Console.WriteLine($"Sua primeira nota é {num3}");

         Console.WriteLine("Digite a segunda nota: ");

         num4 = int.Parse(Console.ReadLine());

         Console.WriteLine("Digite sua terceira nota: ");

         num5 = int.Parse(Console.ReadLine());


          media = (num3 + num4 + num5) / 3;

          Console.WriteLine("Sua nota é: " + media);



        }
    }
}
