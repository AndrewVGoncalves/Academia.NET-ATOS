using System;
namespace setimo{
    class Program    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
            *soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1 / n
            *n = 10
            *s = 1/1 + 1/2+ 1/3+ 1/4 + 1/5 + 1/6 + 1/7 + 1/8 + 1/9 +1/10*/
            
            int n, i;
            double s=0, a;
            Console.WriteLine("Digite um numero :");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                //a = i;
                s += 1 / (double) i;
            }
            Console.WriteLine("O resultado da soma: " + s);
        }
    }
}
      