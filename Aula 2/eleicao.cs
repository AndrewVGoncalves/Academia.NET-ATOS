/*
Para uma eleição, receba o numero de eleitores,
a quantidade de votos brancos, nulos e validos.
Mostre o percentual de cada tipo de voto.
*/
using System;

namespace eleicao{
    public class Program{
        public static void Main(string[] args){
            int numEleitores, votoBranco, votoNulo, votoValido;
            double percentual;

            Console.WriteLine("Digite a quantidade de eleitores: ");
            numEleitores = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos Brancos: ");
            votoBranco = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos nulos: ");
            votoNulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de votos validos: ");
            votoValido = int.Parse(Console.ReadLine());

            percentual = ((votoBranco*100)/numEleitores);
            Console.WriteLine("O percentual de votos brancos = "+percentual);

            percentual = ((votoNulo*100)/numEleitores);
            Console.WriteLine("O percentual de votos brancos = "+percentual);

            percentual = ((votoValido*100)/numEleitores);
            Console.WriteLine("O percentual de votos brancos = "+percentual);
        }
    }
}