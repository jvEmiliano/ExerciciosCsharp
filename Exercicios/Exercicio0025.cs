using System;
using System.Threading;

namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0025
    {
        public static void Executar()
        {
            /* Exercício028: Escreva um programa que faça o computador "pensar" em um número inteiro
            entre 0 e 5 e peça para o usuário tentar descobrir qual foi o número escolhido pelo
            computador.O programa deverá escrever na tela se o usuário venceu ou perdeu.*/

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Concat(Enumerable.Repeat("-=", 30)));
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Vou pensar em um número entre 0 e 5. Tente adivinhar...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Concat(Enumerable.Repeat("-=", 30)));
            Console.ResetColor();

            Random random = new Random();
            int numeroSorteado = random.Next(0, 6);

            Console.Write("Em que número eu pensei? ");
            int.TryParse(Console.ReadLine(), out int numero);

            while (numero > 5 || numero < 0)
            {
                Console.Write("Em que número eu pensei? ");
                int.TryParse(Console.ReadLine(), out numero);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("PROCESSANDO...");
            Thread.Sleep(1000);
            Console.ResetColor();

            if (numero == numeroSorteado)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("PARABÉNS! Você conseguiu me vencer!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("GANHEI! Eu pensei no número {0} e não no {1}!", numeroSorteado, numero);
            }
            Console.ResetColor();
        }
    }
}