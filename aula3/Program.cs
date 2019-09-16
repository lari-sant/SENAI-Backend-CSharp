using System;

namespace aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos as notas  que utilizaremos 
            double nota1, nota2, nota3, media;
            
            // Capturamos a 1 nota
            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine() );

              // Capturamos a 2 nota
            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine() );

              // Capturamos a 3 nota
            Console.WriteLine("Digite sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine() );

            // Calculamos a media das notas 
            media = (nota1 + nota2 + nota3) /3;

            // verificamos se a media do aluno é >=6
            if(media >= 6) {

                Console.WriteLine($"Média: {media} Aluno aprovado!");

            } else {

                Console.WriteLine($"Média: {media} Aluno reprovado");
            }

        }
    }
}
