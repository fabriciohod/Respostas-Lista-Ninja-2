using System;

namespace Q3
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.Clear();
            int pontos = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write ("Digite a distancia: ");
                int distacia = int.Parse (Console.ReadLine ());
                Console.Write ("Digite acertou ou errou: ");
                string cesta = Console.ReadLine ().ToLower ();
                pontos += ContagemDePontos (distacia, cesta);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine ($"A sua pontuacao foi {pontos}");
        }
        static int ContagemDePontos (int distacia, string cesta)
        {
            int pontosPorDistancia = 0;
            if (cesta is "acertou")
            {
                if (distacia <= 800) pontosPorDistancia += 1;
                else if (distacia <= 1400) pontosPorDistancia += 2;
                else pontosPorDistancia += 3;
                return pontosPorDistancia;
            }
            return pontosPorDistancia;
        }
    }
}