using System;

namespace quarto {
  class Program {
    static void Main(string[] args) {
      int[] vetor = new int[]{ 1, 3, 5, 7, 9, 10, 12, 14, 15, 17 };
      int i;
      
      Console.WriteLine("--Digitando os valores do vetor: --");
      for (i = 0; i < 10; i++) {
        Console.Write("Elemento " + (i + 1) + " = ");
        vetor[i] = int.Parse(Console.ReadLine());
      }

      for (i = 0; i < 10; i++) {
        Console.Write(vetor[i] + " ");
      }

      for (i = 0; i < 10; i++) {
        vetor[i] = vetor[i] * 2;
      }

      Console.WriteLine();

      for (i = 0; i < 10; i++) {
        Console.Write(vetor[i] + " ");
      }

    }
  }
}