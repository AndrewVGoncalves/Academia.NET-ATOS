using System;

namespace terceiro{
    class Program{
        static void Main(string[] args)
        {
            //Faça um programa que recebe um numero (até 10) e mostra a tabuada deste numero:
            int n, i;
            Console.WriteLine("digite um numero:");
            n = int.Parse(Console.ReadLine());
            for(i=0; i<=10; i++){
                Console.WriteLine(i+" X "+n+" = "+(n*i));
            }
        }
    }
}