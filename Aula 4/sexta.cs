using System;
namespace ProjetoDia5{
    class Program    {
        static void Main(string[] args) {
            int i, x;
            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());
            for (i = 0; i <= 100; i=i+x)
            {
                Console.WriteLine("O valor de i é igual " + i);
            }
            
            //Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e
            //  então mostre na tela todos os números de 0 a 100, pulando de x em x.

        }
    }
}
