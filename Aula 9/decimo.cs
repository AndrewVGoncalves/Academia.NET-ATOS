using System;

namespace decimo{
    class Program    {
        static void Main(string[] args) {

            /*Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            *Crie um segundo vetor, substituindo
            * os valores nulos por 2.
            *Mostre os vetores lidos e o vetor resultado. */
            
            int[] vetor = new int[20];
            int[] nvetor = new int[20];
            int i;
            for (i = 0; i < 20; i++) {
                Console.WriteLine("Digite o elemento " + (i + 1));
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 20; i++) {
                if (vetor[i] == 0) {
                    nvetor[i] = 2;   
                }
                else {
                    nvetor[i] = vetor[i];
                }
            }

            Console.WriteLine("Vetor original: ");
            
            for (i = 0; i < 20; i++) {
                Console.WriteLine("Elemento "+(i+1)+" = "+vetor[i]);
            }
            
            Console.WriteLine("Vetor novo: ");
            for (i = 0; i < 20; i++) {
                Console.WriteLine("Elemento " + (i + 1) + " = " + nvetor[i]);
            }
        }
    }
}