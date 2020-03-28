using System;
using System.Globalization;

namespace Q1
{
    class Program
    {
        static void Main (string[] args)
        {
            (int h, int m) inicio = Inicio ();
            (int h, int m) termino = Termino ();
            Console.WriteLine (TempoDeDuracao (inicio, termino));
        }
        static string TempoDeDuracao ((int horas, int minutos) inicio, (int horas, int minutos) final)
        {
            if ((inicio.minutos + final.minutos) >= 60)
            {
                inicio.horas += (inicio.minutos + final.minutos) / 60;
            }
            if ((inicio.horas + final.horas) > 23)
            {
                return $"O JOGO DUROU: DIAS {MathF.Abs((inicio.horas - final.horas) % 24)}," +
                    $" {MathF.Abs((inicio.horas - final.horas) /60)}" +
                    $" HORA(S) E {MathF.Abs(inicio.minutos - final.minutos)} MINUTO(S)";
            }
            return $"O JOGO DUROU: {MathF.Abs(inicio.horas - final.horas)}" +
                $" HORA(S) E {MathF.Abs(inicio.minutos - final.minutos)} MINUTO(S)";
        }

        static (int, int) Inicio ()
        {
            (int h, int m) inicio;
            Console.Write ("Digite a Hora INICIO da partida: ");
            inicio.h = int.Parse (Console.ReadLine ());
            Console.Write ("Digite os minutosde INICIO da partida: ");
            inicio.m = int.Parse (Console.ReadLine ());
            return inicio;
        }
        static (int, int) Termino ()
        {
            (int h, int m) termino;
            Console.Write ("Digite a Hora TERMINO da partida: ");
            termino.h = int.Parse (Console.ReadLine ());
            Console.Write ("Digite os minutosde TERMINO da partida: ");
            termino.m = int.Parse (Console.ReadLine ());
            return termino;
        }
    }
}