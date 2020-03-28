using System;

namespace Q4
{
    class Program
    {
        static void Main (string[] args)
        {
            (int x, int y) numeros;
            Console.Write ("Digite um numero: ");
            numeros.x = int.Parse (Console.ReadLine ());
            Console.Write ("Digite um numero: ");
            numeros.y = int.Parse (Console.ReadLine ());
            System.Console.WriteLine ($"O resultado e {SumDosAnteriores(numeros)}");
        }
        static int SumDosAnteriores ((int x, int y) numeros)
        {
            int sum = 0;
            if (numeros.y < 0)
            {
                for (int i = numeros.y; i != numeros.x; i++)
                {
                    if (i % 2 == -1) sum += i;
                    if (i % 2 == 1) sum += i;
                }
            }
            for (int i = numeros.x; i <= numeros.y; i++)
            {
                if (i % 2 == -1) sum += i;
                if (i % 2 == 1) sum += i;
            }
            return sum;
        }
    }
}