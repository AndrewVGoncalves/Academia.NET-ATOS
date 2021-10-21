/*Leia 2 números do usuário, após isso, mostre esta mensagem ao usuário:
“Informe 1 para soma, 2 para subtração, 3 para multiplicação e 4 para divisão”
Leia a escolha do usuário e faça o que ele pediu!*/

using System;

namespace Terceiro{
    public class Program{
        public static void Main(string[] args){

            int val1,val2,operacao,resultado;

            Console.WriteLine("Digite um valor:");
            val1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro valor:");
            val2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma operação para realizar:");
            operacao = int.Parse(Console.ReadLine());

            if(operacao == 1){
                resultado = val1+val2;
                Console.WriteLine("O resultado da operação == "+resultado);                            
            }
            else if(operacao == 2){
                resultado = val1-val2;
                Console.WriteLine("O resultado da operação == "+resultado);
            }
            else if(operacao == 3){
                resultado = val1*val2;
                Console.WriteLine("O resultado da operação == "+resultado);
            }
            else if(operacao == 4){
                resultado = val1/val2;
                Console.WriteLine("O resultado da operação == "+resultado);
            }
            else{
                Console.WriteLine("Este numero não corresponde a nenhuma operação");
            }
           
        }
    }
}