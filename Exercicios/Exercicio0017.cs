using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0017
    {
        public static void Executar()
        {
            Console.Write("Digite o ângulo que você deseja: ");
            double.TryParse(Console.ReadLine(), out double angulo);

            Console.WriteLine($"O ângulo de {angulo} tem o SENO de {Math.Sin(angulo * (Math.PI / 180)).ToString("F2")}");
            Console.WriteLine($"O ângulo de {angulo} tem o COSSENO de {Math.Cos(angulo * (Math.PI / 180)).ToString("F2")}");
            Console.WriteLine($"O ângulo de {angulo} tem a TANGENTE de {Math.Tan(angulo * (Math.PI / 180)).ToString("F2")}");
        }
    }
}