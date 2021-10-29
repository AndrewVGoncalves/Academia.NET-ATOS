using System;

namespace oitavo {
    class Program {
        static void Main(string[] args) {
            /*Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor
             *e armazene em um novo vetor primeiramente todos os números pares lidos e
             * após todos os ímpares. Exemplo:
             *a.     lê: |7|40|3|9|21|0|63|31|7|22|
             *b. escreve: |40|0|22|7|3|9|21|63|31|7| */
            int[] v1 = new int[10];
            int[] v2 = new int[10];
            int i, p = 0;
            
            for (i = 0; i < 10; i++) {
                Console.Write("digite um valor para o elemento " + (i + 1) + " do vetor: ");
                v1[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < 10; i++) {
                if (v1[i]%2==0){

                    v2[p] = v1[i];
                    p++;
                }                
            }

            for (i = 0; i < 10; i++) {
                if (v1[i]%2!=0){

                    v2[p] = v1[i];
                    p++;
                }
            }
            
            for (p = 0; p < 10; p++) {
                Console.WriteLine("Elemento "+ (p+1) +" = " + v2[p]);
            }

        }
    }
}