//Ler um numero e mostrar seu antecessor e seu sucessor.

using System;

namespace antesuc{
    public class Program{
        public static void Main(string[] args){
            int num;

            Console.WriteLine("Digite um numero inteiro:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero antecessor é: "+(num-1)+"\nO numero posterio é: "+(num+1));
        }
    }
}