using System;

namespace terceiro{
    class Program{
        static void Main(string[] args)
        {
            /*Escreva um programa que gera números entre 1000 e 1999
            *e mostra aqueles que divididos por 11 dão resto 5.*/
            int i;
            for(i=1000; i<=1999; i++){
                if(i % 11 == 5){
                    Console.WriteLine("o numero "+i+"dividido por 11 resta 5.");
                }
            }
        }
    }
}