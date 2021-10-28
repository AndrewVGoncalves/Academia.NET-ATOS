using System;

namespace quinto{
    class Program{
        static void Main(string[] args)
        {
            //faça um programa que leia numeros e diga se é par ou impar, até o usuario digitar 0
            //se o usuario digitar 0 o programa deve fechar, caso contrario ele deve permanecer rodando
            
            int valor=1;

            do{
                Console.WriteLine("digite um valor diferente de 0:");
                valor = int.Parse(Console.ReadLine());
                if (valor%2==0)
                {
                    Console.WriteLine("O numero é par\n");
                }
                else
                {
                    Console.WriteLine("o numero é impar\n");
                }
            }while (valor!=0);   
        }
    }
}