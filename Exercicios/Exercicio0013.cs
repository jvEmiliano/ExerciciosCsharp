using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0013
    {
        public static void Executar()
        {
            Console.Write("Informe a temperatura em °C: ");
            double.TryParse(Console.ReadLine(), out double temperaturaCelsius);

            double temperaturaFahrenheit = temperaturaCelsius * 1.8 + 32;
            Console.WriteLine("A temperatura de {0}°C corresponde a {1}°F!", temperaturaCelsius, temperaturaFahrenheit);
        }
    }
}