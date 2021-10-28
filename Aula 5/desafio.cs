using System;


namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma, d, m; //d -> diuvidendo m-> divisor
            soma = 0;
            for (d = 1000, m = 1; m <= 50; d = d - 3, m++)
            {
                if (d % 2 == 0)
                {
                    Console.WriteLine("Par d = " + d);
                    Console.WriteLine("m = " + m);
                    soma += d / m; //soma = soma + (d / m) ;
                }
                else
                {
                    Console.WriteLine("Impar d = " + d);
                    Console.WriteLine("m = " + m);
                    soma -= d / m; //soma = soma - d / m  ;
                }
            }
            Console.WriteLine("O Resultado da operação: " + soma);
        }
    }
}