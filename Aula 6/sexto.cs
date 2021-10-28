using System;

/*3 - Existem números de 4 dígitos (entre 1000 e 9999) que obedecem à seguinte característica:
se dividirmos o número em dois números de dois dígitos,
um composto pela dezena e pela unidade, e outro pelo milhar e pela centena,
somarmos estes dois novos números gerando um terceiro,
o quadrado deste terceiro número é exatamente o número original de quatro dígitos.

Por exemplo:
2025 dividindo: 20 e 25 e somando temos 45 e 45² = 2025.

Escreva um programa para calcular todos os números que obedecem a esta característica.

DICA IMPORTANTE: LEMBREM-SE DA MINHA EXPLICAÇÃO SOBRE RESTO DA DIVISÃO!

resto da divisão de um número por 5 = n%5 - irá variar de 0 até 4.
resto da divisão de um número por 4 = n%4 - irá variar de 0 até 3.
resto da divisão de um número por 3 = n%3 - irá variar de 0 até 2.
resto da divisão de um número por 2 = n%2 - irá variar entre 0 e 1.*/

namespace sexto {
  class Program {
    static void Main (string[]args) {
      double soma = 0, d, m;
        d = 1000;
        m = 1;
      while (m <= 50) {
    	  if (d % 2 == 0) {
    	      Console.WriteLine ("Par d = " + d);
    	      Console.WriteLine ("m = " + m);
    	      soma += d / m;
    	    }
    	  else {
    	      Console.WriteLine ("Impar d = " + d);
    	      Console.WriteLine ("m = " + m);
    	      soma -= d / m;
    	    }
    	  d = d - 3;
    	  m++;
    	  Console.WriteLine ("O Resultado da operação: " + soma);
    	}
    }
  }
}
