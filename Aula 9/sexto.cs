using System;

namespace sexto{
    class Program    {
        static void Main(string[] args)
        {
            //fazer um algoritmo que leia 10 numeros e 
            //os apresente de forma contraria a forma de leitura

            int[] vetor = new int[10];
            int i;
            
            for (i = 0; i < 10; i++) {
                Console.Write("digite um valor para o elemento " + (i + 1) + " = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 9; i >= 0; i--) {
                Console.WriteLine(vetor[i]);

            }
        }
    }
}