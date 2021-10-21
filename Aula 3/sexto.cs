using System;

namespace Sexto {
  public class Program {
    public static void Main(string[] args) {

      int lado1, lado2, lado3;

      Console.WriteLine("Informe o lado 1");
      lado1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o lado 2");
      lado2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o lado 3");
      lado3 = int.Parse(Console.ReadLine());

      if (lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado1 + lado2)) {
        if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1) {
          Console.WriteLine("Equilatero");
        }
        
        else if (lado1 == lado2 || lado2 == lado3 || lado3 == lado1) {
          Console.WriteLine("Isóceles");
        }
        
        else {
          Console.WriteLine("Escaleno");
        }
      }
      
      else {
        Console.WriteLine("Não é um triângulo!");
      }

    }
  }
}