using System;

namespace quinto{
    class Program{
        static void Main(string[] args)
        {
            /*Escreva um programa que pergunta pro usuario o inicio e o fim de uma sequencia
            *e se ele quer mostrar apenas os pares ou apenas os impares*/

            int i, inicio, op, fim;
            Console.WriteLine("digite um numero para começar uma sequencia de numeros e um para terminar");
            inicio = int.Parse(Console.ReadLine());
            fim = int.Parse(Console.ReadLine());

            Console.WriteLine("você gostaria de mostrar os numeros: \ndigite 1 para pares\ndigite 2 para impares");
            op = int.Parse(Console.ReadLine());
            
            for (i = inicio; i <= fim; i++)
            {
                if (op == 1){ //if (par == true) i++ => i=i+1
                    if (i % 2 == 0)
                    {
                        Console.WriteLine("Apresentando os pares: " + i);
                    }
                }
                else {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("Apresentando os impares: " + i);
                    }
                }
            }
        }
    }
}