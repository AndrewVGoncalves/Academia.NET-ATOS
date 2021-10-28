using System;
namespace primeiro{
    class Program    {
        static void Main(string[] args)
        {
            int x,i;
            /*Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela
            * todos os números de 0 a 100 que são divisíveis por x.*/
            
            Console.WriteLine("Digite um valor para x: ");
            x = int.Parse(Console.ReadLine());
            for (i = 1; i <= 100; i++) 
            {
                if (i % x == 0)
                {
                    Console.WriteLine("O número " + i + " é divisivel por " + x);
                }
                //340 / 10 = 34 -> 340%10 = 0 -> para um numero ser divisivel, a regra é que o resto da divisão destes numeros seja 0
            }
        }   
    }
}