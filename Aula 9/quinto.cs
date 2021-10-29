using System;

namespace quinto{
    class Program    {
        static void Main(string[] args)
        {
            //escreva um algoritmo que leia os valores par aum vetor de 10 elementosa
            //e mostre na tela a quantidade de numeros pares e impares

            int[] vetor = new int[10];
            int i,par=0, impar=0;
            
            for (i = 0; i < 10; i++) {
                Console.Write("digite um valor para o elemento " + (i + 1) + " = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++) {
                if (vetor[i] % 2 == 0) {
                    par++;
                }
                else {
                    impar++;
                }
            }

            Console.WriteLine("O vetor possui " + par + " elementos pares e " + impar + " elementos impares");
        }
    }
}