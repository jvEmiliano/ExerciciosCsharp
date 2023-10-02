using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0007
    {
        public static void Executar()
        {
            Console.Write("Uma distância em metros: ");
            double.TryParse(Console.ReadLine(), out double distancia);

            Console.WriteLine($"A medida de {distancia}m corresponde a");

            Console.WriteLine($"{distancia / 1000}km");
            Console.WriteLine($"{distancia / 100}hm");
            Console.WriteLine($"{distancia / 10}dam");
            Console.WriteLine($"{distancia * 10}dm");
            Console.WriteLine($"{distancia * 100}cm");
            Console.WriteLine($"{distancia * 1000}mm");
        }
    }
}