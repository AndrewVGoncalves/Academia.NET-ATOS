using System;

namespace primeiro{
    class Program    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int i;

            Console.WriteLine("-------digitando os numeros do vetor:-------");
            for (i = 0; i < 10; i++)
            {
                Console.Write("elemento "+(i+1)+" = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}