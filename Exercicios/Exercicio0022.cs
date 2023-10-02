using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0022
    {
        public static void Executar()
        {
            /* Exercício025: Crie um programa que leia o nome 
            de uma pessoa e diga se ela tem "SILVA" no nome.*/

            Console.Write("Qual é seu nome completo? ");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine($"Seu nome tem Silva? {nome.Contains("SILVA")}");
        }
    }
}