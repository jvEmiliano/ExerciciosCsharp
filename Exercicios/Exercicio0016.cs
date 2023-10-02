using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0016
    {
        public static void Executar()
        {
            Console.Write("Comprimento do cateto oposto: ");
            double.TryParse(Console.ReadLine(), out double catetoOposto);

            Console.Write("Comprimento do cateto adjacente: ");
            double.TryParse(Console.ReadLine(), out double catetoAdjacente);

            double hipotenusa = Math.Sqrt(Math.Pow(catetoOposto, 2) + Math.Pow(catetoAdjacente, 2));

            Console.WriteLine("A hipotenusa vai medir {0}", hipotenusa.ToString("F2"));
        }
    }
}