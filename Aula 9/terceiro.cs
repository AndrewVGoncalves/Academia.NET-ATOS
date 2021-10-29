using System;

namespace terceiro{
    class Program    {
        static void Main(string[] args)
        {
            int i,c=0;
            int[] v = new int[5];
            for (i = 0; i < 5; i++)
            {
                Console.Write("Elemento " + (i + 1) + " = ");
                v[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 5; i++)
            {
                if (v[i] % 2 == 0)
                {
                    Console.WriteLine("Elemento "+v[i]+" par");
                    c++;
                }
            }
            Console.WriteLine("O vetor possui " + c + " elementos pares");
        }
    }
}