using System;

namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0024
    {
        public static void Executar()
        {
            /* Exercício027: Faça um programa que leia o nome completo de uma pessoa, 
            mostrando em seguida o primeiro e o último nome separadamente.*/

            Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine().Trim();

            string[] nomeArray = nome.Split(" ");

            Console.WriteLine("Muito prazer em te conhecer!");
            Console.WriteLine("Seu primeiro nome é {0}", nomeArray[0]);
            Console.WriteLine("Seu último nome é {0}", nomeArray[nomeArray.Length - 1]);
        }
    }
}