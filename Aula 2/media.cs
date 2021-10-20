/*
Entrar com 3 notas de um aluno e imprimir a média(nota) final.
*/

using System;

namespace media{
    public class Program{
        public static void Main(string[] args){
            double nota1, nota2, nota3;

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("a media deste aluno é igual a: "+((nota1+nota2+nota3)/3));
        }
    }
}