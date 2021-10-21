using System;

namespace Terceiro{
    public class Program{
        public static void Main(string[] args){

            double salario, aumento;

            Console.WriteLine("Digite o salario do funcionario:");
            salario = double.Parse(Console.ReadLine());

            if(salario > 0 && salario <= 900){
                aumento = 0.5;
                salario = salario+(salario*aumento);
                Console.WriteLine("O salario recebeu um aumento de 5%: "+salario);
            }
            else if(salario > 901 || salario <= 1400) {
                aumento = 0.8;
                salario = salario+(salario*aumento);
                Console.WriteLine("O salario recebeu um aumento de 8%: "+salario);
            }
            else if(salario > 1400){
                aumento = 0.1;
                salario = salario+(salario*aumento);
                Console.WriteLine("O salario recebeu um aumento de 10%: "+salario);
            }
           
        }
    }
}