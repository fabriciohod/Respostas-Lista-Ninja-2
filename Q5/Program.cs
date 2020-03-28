using System;

namespace Q5
{
    class Program
    {
        static void Main (string[] args)
        {
            int qtd = 0;
            Console.Write ("Digite um nomero: ");
            int x = int.Parse (Console.ReadLine ());
            Console.Write ("Figite um numero: ");
            int y = int.Parse (Console.ReadLine ());
            if (x > y)
            {
                int aux = 0;
                aux = x;
                x = y;
                y = aux;
            }
            while (x < y)
            {
                Console.Write ($"{qtd++} ");
                if (qtd == (y + 1)) break;
            }
        }
    }
}