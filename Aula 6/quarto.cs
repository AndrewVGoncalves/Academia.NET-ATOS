using System;

namespace quarto{
    class Program{
        static void Main(string[] args)
        {
            //efetuar a multiplicação de dois valores informados pelo usuario sem usar asterisco
            int n1, n2, i=1, multiplicacao;
            Console.WriteLine("digite um numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite um segundo numero para realizar uma multiplicação:");
            n2 = int.Parse(Console.ReadLine());
            multiplicacao = n2;
            while (i < n1) {
                 multiplicacao += n2;
                 i++;
            }
            Console.WriteLine(multiplicacao);
        }
    }
}