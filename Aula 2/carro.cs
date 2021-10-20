//Suponha que um vendedor de carros trabalhe em uma empresa onde todos os veículos custem 30.000 reais.
//Faça um programa que leia o nome do funcionário, o seu salario base (Exemplo: 1000),
//e a quantidade de veículos vendidos. Para cada veiculo vendido ele recebe 15% de comissão,
//que deve ser somado ao seu salario. Apresente o novo salario da mesma forma do exercício anterior.
using System;

namespace carro{
    public class Program{
        public static void Main(string[] args){
            int quantVenda;
            double salario, valorVeiculo = 30000, percentual = 15;
            string nome;

            Console.Write("Digite o nome do funcionario: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o salario do funcionario "+nome+": ");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de veiculos vendidos: ");
            quantVenda = int.Parse(Console.ReadLine());

            salario = (salario + (((valorVeiculo*quantVenda)*percentual)/100));

            Console.WriteLine("o novo salario é igual a: "+salario);

        }
    }
}