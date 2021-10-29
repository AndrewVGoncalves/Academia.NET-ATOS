using System;

namespace oitavo {
    class Program {
        static void Main(string[] args) {
            /*Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor
            *e após escreva a posição de cada número menor que zero desse vetor.
            *Exemplo:
            *a. lê: |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
            *b. escreve: |3|5|6|7|9|10|14|. . .*/

            double[] vetor = new double[30];
            int i;
            
            for (i = 0; i < 30; i++) {
                Console.Write("digite um valor (positivo ou negativo) para o elemento " + (i + 1) + " = ");
                vetor[i] = double.Parse(Console.ReadLine());
            }

            for (i = 0; i < 30; i++) {
                if(vetor[i]<0){
                    Console.WriteLine("a posição do numero negativo, no vetor é: "+i);
                }
            }
        }
    }
}

