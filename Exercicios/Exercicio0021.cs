using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0021
    {
        public static void Executar()
        {
            /* Exercício024: Crie um programa que leia o nome de 
            uma cidade diga se ela começa ou não com o nome "SANTO".*/

            Console.Write("Em que cidade você nasceu? ");
            string cidade = Console.ReadLine().ToUpper();

            Console.WriteLine(cidade.Contains("SANTO"));
        }
    }
}