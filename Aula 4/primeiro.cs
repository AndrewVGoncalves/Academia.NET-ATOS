using System;

namespace primeiro{
    class Program    {
        static void Main(string[] args)
        {
            //estruturas condicionais
            // criar if, else if, if dentro if
            // switch case -> estruturas seletivas -> selecionar -> menu -> servir para criar menus e comparações mais "simples"             só funciona/compara inteiro e caracteres -> não poderemos comparar strings (existem funçoes), pontos flutuantes como float e double
            int n, x;
            Console.WriteLine("Digite um número ");
            n = int.Parse(Console.ReadLine());
            switch (n){ // variável de controle será o N, ou seja, as comparações serão nesta variável            {
                case 0:
                    Console.WriteLine("O n vale 0");
                    x = 11;
                    Console.WriteLine("Oi");
                    break; 
                case 2:
                    x = 2 * 2;
                    Console.WriteLine("O valor do agora x é " + x);
                    break;
                case 5:
                    Console.WriteLine("Digitou 5");
                    break;
                default:
                    Console.WriteLine("Digite um valor válido!");
                    break;
            }
            
        }
    }
}