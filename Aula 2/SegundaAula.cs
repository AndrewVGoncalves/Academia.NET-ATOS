using System;

namespace SegundaAula{
    public class Program{
        public static void Main(string[] args){
            //Faça um programa onde o salario e o percentual de aumento são entradas.
            //A saída é o novo salário

            double  salario, percentual;

            Console.WriteLine("Digite um Salario atual: ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um percentual de aumento: ");
            percentual = double.Parse(Console.ReadLine());

            salario = (salario + ((salario*percentual)/100));

            Console.WriteLine("Novo salário: " + salario);
        }
    }
}