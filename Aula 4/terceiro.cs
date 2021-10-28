/*Uma loja fornece 10% de desconto para funcionários e 5% de desconto para clientes vips.
Faça um programa que calcule o valor total a ser pago por uma pessoa.
O programa deverá ler o valor total da compra efetuada
e um código que identifique se o comprador é um cliente comum (1), funcionário (2) ou vip (3)*/

using System;

namespace terceiro {
    class Program {
        static void Main(string[] args) {

            double total, tipo, desc;

            Console.WriteLine("Digite o valor total da compra:");
            total = double.Parse(Console.ReadLine());

            Console.WriteLine("Se esta compra foi realizada por:\n um cliente presisone 1,\n um funcionario pressione 2\n ou por um cliente VIP pressione 3");
            tipo = double.Parse(Console.ReadLine());

            switch (tipo){
                case 1:
                    desc = 1;
                    Console.WriteLine("O valor sem desconto é igual a: "+total);
                    break; 
                
                case 2:
                    desc = 0.1;
                    Console.WriteLine("O valor com desconto de funcionario é igual a: "+(total-(total*desc)));
                    break;
                
                case 3:
                    desc = 0.05;
                    Console.WriteLine("O valor com desconto de cliente vip é igual a: "+(total-(total*desc)));
                    break;
                
                default:
                    Console.WriteLine("operação inválida!");
                    break;
            }
            
        }
    }
}