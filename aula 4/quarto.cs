using System;
namespace quarto {
    class Program {
        static void Main(string[] args) {
            /* operador ternário -> tudo que o ternário faz , o if faz...
            * forma simplicada da estrutura if-else -> não é muito usual
            * operador ternário "?"
            * condição ? instrução1 : instrução 2 */
            int i;
            char x;
            Console.WriteLine("Digite um valor: ");
            i = int.Parse(Console.ReadLine());
            // Se o numero digitado for par, eu quero mostrar "p" e se for impar "i" na tela 
            x = (i % 2 == 0) ? x = 'p' : x = 'i';
            Console.WriteLine("Resultado do operador ternário: " + x);
        }            
    }
}