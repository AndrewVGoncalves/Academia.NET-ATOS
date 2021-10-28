/*Crie um programa para fazer a leitura de um numero.
Se o numero for impar, transforme este numero em par.
Se for par, mantenha o mesmo numero.*/

using System;
namespace quinto {
    class Program {
        static void Main(string[] args) {
            int i;
            Console.WriteLine("Digite um valor: ");
            i = int.Parse(Console.ReadLine());
            // Se o numero digitado for par, só mostra, se for impar transforma em par
            i = (i % 2 == 0) ? i = i : i+1;
            Console.WriteLine("Resultado do operador ternário: " + i);
        }            
    }
}