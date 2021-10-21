using System;

namespace CondDois{
    public class Program{
        public static void Main(string[] args){

            int valor = 5;
            int digitado;

            Console.WriteLine("Digite um valor");
            digitado = int.Parse(Console.ReadLine());
            if(valor == digitado)
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