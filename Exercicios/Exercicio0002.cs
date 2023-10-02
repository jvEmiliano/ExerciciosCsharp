using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0002
    {
        public static void Executar()
        {
            Console.Write("Digite seu nome: ");
            string? nome = Console.ReadLine();

            Console.WriteLine($"É um prazer te conhecer, {nome}!");
        }
    }
}