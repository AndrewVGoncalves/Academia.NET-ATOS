using System;
namespace sextoum{
    class Program {
        static void Main(string[] args)
        {
            /*Escreva um algoritmo leia pelo teclado o valor de uma variável inteira chamada opcao, porém,
            * o programa só pode seguir sua execução caso o valor de opcao seja entre 1 e 4.Se o valor
            * digitado não for entre 1 e 4, a variável opcao deverá ser lida novamente pelo teclado*/
            
            int opcao,i;
            for (i = 0; true; i++)
            {
                Console.WriteLine("Digite uma opção de 1 a 4: ");
                opcao = int.Parse(Console.ReadLine());
                if(opcao>4 || opcao < 1)
                {
                    Console.WriteLine("Digite um valor entre 1 e 4");
                    continue;
                }
                else                {
                    Console.WriteLine("Escolhida a opção " + opcao);
                    break;
                }
            }
        }
    }
}