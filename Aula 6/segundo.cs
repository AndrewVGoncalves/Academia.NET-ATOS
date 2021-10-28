using System;

namespace segundo{
    class Program{
        static void Main(string[] args)
        {
            //somar todos os numeros até 100 usando apenas o while
            int i = 0, somatorio = 0;
            while (i<=100){
            	somatorio = somatorio + i;
                i++;
            }
            Console.WriteLine(somatorio);
        }
    }
}