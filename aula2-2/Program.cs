using System;

namespace aula2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Declaramos as notas  que utilizaremos 
            float nota1, nota2, nota3, media;
            string resultado;
            
            // Capturamos a 1 nota
            Console.WriteLine("Digite sua primeira nota: ");
            nota1 = float.Parse(Console.ReadLine() );

              // Capturamos a 2 nota
            Console.WriteLine("Digite sua segunda nota: ");
            nota2 = float.Parse(Console.ReadLine() );

              // Capturamos a 3 nota
            Console.WriteLine("Digite sua terceira nota: ");
            nota3 = float.Parse(Console.ReadLine() );

            // Calculamos a media das notas 
            media = (nota1 + nota2 + nota3) /3;

            // verificamos se a media do aluno é >=6
            if(media >= 6) {

                resultado = "Aprovado";

            } else if(media < 6 && media >=4) {

                 resultado = "Recuperação";
            }else{

                resultado = "Reprovado";
            }

            Console.WriteLine($"Média: {media} - Aluno está {resultado} ");

        }
    }
}

  
