using System;

namespace aula3 {
    class Program {
        static void Main (string[] args) {

             // Laço contado  - For -Incremento (+)
             for (int cont = 1; cont <= 100; cont++) {

            //     // Verificamos se o numero é diferente de par 
                 if (cont % 2 != 0) {
                     Console.WriteLine ("For 0 - 100 " + cont);
                 }
             }
              //Laço contado  - For -Incremento (-)
              for (int cont = 100; cont >= 0; cont--) {

                // Verificamos se o numero é diferente de par 
                 if (cont % 2 != 0) {
                     Console.WriteLine ("For 100 - 0 - " + cont);
               }
             }

            // Laço Condicional While 

            double nota   = 0;
            double acumuladora   = 0;
            int    cont   = 0;
            string sair = "";
            

            while(sair != "sim"){
            
                Console.WriteLine("Digite a nota de um aluno");
                nota  = double.Parse(Console.ReadLine()) ;

                if(nota != 1000){
                    acumuladora += nota;
                    cont++;

                    Console.WriteLine("Deseja sair da aplicação? sim/não");
                    sair = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Media das notas : " + (acumuladora/cont));

            }
         }
    }
}         