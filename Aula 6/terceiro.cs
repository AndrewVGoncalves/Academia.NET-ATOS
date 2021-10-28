using System;

namespace terceiro{
    class Program{
        static void Main(string[] args)
        {
            //somar todos os numeros impares e calcular a média da operação
            int i = 0, somatorio = 0, media;
            while (i<=100){
            	if (i%2!=0){
                  somatorio = somatorio + i;
                }
                i++;
            }
            Console.WriteLine(somatorio);
            media = somatorio/50;
            Console.WriteLine(media);
        }
        /*solução do professor:
        int i = 0, count = 0, somatorio = 0;
      double media;
      while (i <= 100){
	  if (i % 2 != 0) {
	      somatorio = somatorio + i;
	      count++;
	        }
	        i++;
	    }
      Console.WriteLine (somatorio);
      media = somatorio / count;
      Console.WriteLine (media);
        }
        */

    }
}