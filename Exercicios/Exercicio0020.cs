using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0020
    {
        public static void Executar()
        {
            Console.Write("Informe um número: ");
            string? numero = Console.ReadLine();

            Console.WriteLine("Analisando o número " + numero);

            Console.WriteLine($"Unidade: " + numero[3]);
            Console.WriteLine("Dezena: " + numero[2]);
            Console.WriteLine("Centena: " + numero[1]);
            Console.WriteLine("Milhar: " + numero[0]);
        }
    }
}