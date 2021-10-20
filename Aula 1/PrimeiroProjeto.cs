using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // declarei duas variáveis inteiras, uma chamada n com a atribuição de 10 e uma variável chamada x

            char letra = 'R'; //declarei uma variável letra 'R'

            double media = 4.3333;

            double preco;

            string nome;

            string frase; // vetor de char 

            frase = "Olá pessoal, boa noite a todos.";

            Console.WriteLine(frase);

            Console.WriteLine("O numero armazenado em n é igual " + n);

            Console.WriteLine("A letra armazenada em letra é " + letra);

            Console.WriteLine("O valor armazenado em media é igual a " + media);

            Console.Write("Digite o nome: ");

            nome = Console.ReadLine();

            Console.WriteLine("O nome digitado foi: " + nome);

            Console.Write("Digite um valor inteiro para x: \n"); // Console.WriteLine("Digite um valor para x: ");

            int x =  int.Parse(Console.ReadLine());
            //x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O número digitado para x é igual a " + x);

            Console.WriteLine("Digite um preço: ");

            preco = Convert.ToDouble(Console.ReadLine()); //preco = double.Parse(Console.ReadLine());

            Console.WriteLine("O preço digitado foi: " + preco);


            /*Console.WriteLine("Alow turma!");  // comando de saída  
            /* ola pessoal, isso aqui não vai ser interpretado na compilação
             * e seguira sem ser interpretado até eu inserir a tag de fim de comentário */

            /*Console.WriteLine("depois do comentário");*/
        }
    }
}
