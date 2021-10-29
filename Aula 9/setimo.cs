using System;

namespace setimo{
    class Program    {
        static void Main(string[] args)
        {
            //fazer um algoritmo que leia valores para dois vetores de 20 elementos
            //e então realize a soma dos elementos de mesma posição
            //armazenando o resultado em outro vetor

            int[] vetora = new int[20];
            int[] vetorb = new int[20];
            int[] vetorresult = new int[20];
            int i;
            
            for (i = 0; i < 20; i++) {
                Console.Write("digite um valor para o elemento " + (i + 1) + " do vetor 1: ");
                vetora[i] = int.Parse(Console.ReadLine());

                Console.Write("digite um valor para o elemento " + (i + 1) + " do vetor 2: ");
                vetorb[i] = int.Parse(Console.ReadLine());

                vetorresult[i] = vetora[i] + vetorb[i];
            }

            for (i = 0; i < 20; i++) {
                Console.WriteLine(vetora[i] + " + " + vetorb[i] + " = " + vetorresult[i]);
            }
        }
    }
}