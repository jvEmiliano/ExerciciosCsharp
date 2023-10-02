using System;

namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0023
    {
        public static void Executar()
        {
            /* Exercício026: Faça um programa que leia uma frase pelo teclado
            e mostre quantas vezes aparece a letra "A", em que posição ela
            aparece a primeira vez e em que posição ela aparece a última vez.*/

            int quant = 0;

            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine().Trim().ToUpper();

            foreach(char letra in frase)
                if(letra == 'A')
                    quant++;

            Console.WriteLine("A letra A aparece {0} vezes na frase.", quant);
            Console.WriteLine("A primeira letra A apareceu na posição {0}", frase.IndexOf("A") + 1);
            Console.WriteLine("A última letra A apareceu na posição {0}", frase.LastIndexOf("A") + 1);
        }
    }
}