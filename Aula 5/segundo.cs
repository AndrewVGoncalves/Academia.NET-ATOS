using System;

namespace segundo{
    class Program{
        static void Main(string[] args)
        {
            /*Escreva um algoritmo leia pelo teclado a quantidade de alunos de uma turmaOK
            * e então,
            * para cada aluno, leia suas 3 notas do semestre ok
            * e mostre na tela sua média final, ok
            * e se está aprovado com nota 6 ou não.*/
            
            int q , i;
            double n1, n2, n3, media;
            
            //Console.Write("Oi pessoal, tudo bem?\n");
            //Console.WriteLine("Oi pessoal, tudo bem?");

            Console.WriteLine("Quantos alunos tem na turma?");
            
            q = int.Parse(Console.ReadLine());
            for (i = 0; i < q; i++){  //for (i = 1; i <= q; i++)             
                //fazer a leitura -> aqui dentro, pra cada execução deste laço, é 1 aluno distinto...
                
                Console.WriteLine("Digite as três notas do aluno " + (i + 1));
                n1 = int.Parse(Console.ReadLine());
                n2 = int.Parse(Console.ReadLine());
                n3 = int.Parse(Console.ReadLine());
                media = (n1 + n2 + n3) / 3;
                Console.Write("O aluno " + (i + 1) + " tem média = " + media);
                 if (media >= 6)
                {
                    Console.WriteLine(" e está aprovado!");
                }
                else                {
                    Console.WriteLine(" e está reprovado!");
                }
            }
        }
    }
}