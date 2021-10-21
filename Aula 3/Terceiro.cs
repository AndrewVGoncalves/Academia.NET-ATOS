using System;

namespace Terceiro{
    public class Program{
        public static void Main(string[] args){

            int valorcomp;
            int digitado;

            Console.WriteLine("Digite um valor para comparação:");
            digitado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor para comparação:");
            valorcomp = int.Parse(Console.ReadLine());

            if(valorcomp == digitado)
            {
                Console.WriteLine("Os valores são iguais!");
            }
            else
            {
                Console.WriteLine("Os valores são diferentes!");
            }
        }
    }
}