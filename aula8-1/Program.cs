using System;

namespace aula8_1
{
    class Program
    {
        static void Main(string[] args)

        {   
            int numero;
           try{

               //Escrevemos um bloco de codico
            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());
           }catch(Exception ex){
               
               //Mostramos a exceção da regra
               //Erro gerado na aplicação
               Console.WriteLine("Ops :( Deu ruim. Erro: " + ex);
           }
        }
    }
}
