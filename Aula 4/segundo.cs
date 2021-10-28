/*Implemente na calculadora desenvolvida as seguintes funções:

Se a operação digitada for “+”, será efetuada a soma;
Se a operação digitada for “-”, será efetuada a subtração;
Se a operação digitada for “x”, será efetuada a multiplicação
Se a operação digitada for “/”, será efetuada a divisão;

Se não for inserida nenhuma das operações anteriores,
deve ser apresentado uma mensagem para digitar uma operação válida e
apresente o resultado das quatro operações.*/

using System;

namespace segundo {
    class Program {
        static void Main(string[] args) {

            int n1, n2;
            char op;

            Console.WriteLine("Digite um número ");
            n1 = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite um segundo número ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma operação matemática com os seguintes simbolos:");
            Console.WriteLine("+, -, *, /;");
            op = char.Parse(Console.ReadLine());

            switch (op){
                case '+':
                    Console.WriteLine("O resultado da operação: "+n1+" + "+n2+" = "+(n1+n2));
                    break; 
                
                case '-':
                    Console.WriteLine("O resultado da operação: "+n1+" - "+n2+" = "+(n1-n2));
                    break;
                
                case '*':
                    Console.WriteLine("O resultado da operação: "+n1+" * "+n2+" = "+(n1*n2));
                    break;
                case '/':
                    Console.WriteLine("O resultado da operação: "+n1+" / "+n2+" = "+(n1/n2));
                    break;

                default:
                    Console.WriteLine("operação inválida!");
                    break;
            }
            
        }
    }
}