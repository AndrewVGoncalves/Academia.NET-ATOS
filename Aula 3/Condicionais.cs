using System;

namespace Condicionais{
    public class Program{
        public static void Main(string[] args){
            int valor;

            Console.WriteLine("Digite um valor:");
            valor = int.Parse(Console.ReadLine());
            
            if(valor > 0){
                Console.WriteLine("O valor é positivo!");
            }

            else if (valor < 0){
                Console.WriteLine("O valor é negativo!");
            }
            
            else{
                Console.WriteLine("O valor é zero!");
            }
        }
    }
}