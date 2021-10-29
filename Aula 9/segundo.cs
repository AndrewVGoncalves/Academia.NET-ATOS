using System;

namespace segundo{
    class Program    {
        static void Main(string[] args)
        {
            int[] vetor = new int[99];
            int i;

            Console.WriteLine("-------digite o tamanho do vetor:-------");
            int tam = int.Parse(Console.ReadLine());

            Console.WriteLine("-------digitando os numeros do vetor:-------");
            for (i = 0; i < tam; i++)
            {
                Console.Write("elemento "+(i+1)+" = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < tam; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}