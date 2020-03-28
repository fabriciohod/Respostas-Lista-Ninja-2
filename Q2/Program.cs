using System;

namespace Q2
{
    class Program
    {
        static void Main (string[] args)
        {
            System.Console.Write ("Digite um numero: ");
            int n = int.Parse (Console.ReadLine ());
            
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write ($"{i} ");
                }
            }
            else
            {
                System.Console.WriteLine ("Fim");
            }
        }
    }
}