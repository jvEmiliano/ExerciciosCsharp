using System;


namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0027
    {

        public static void Executar()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Me diga um número qualquer: ");
            Console.ResetColor();
            int.TryParse(Console.ReadLine(), out int num);

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("O número {0} é ", num);
            Console.ForegroundColor = ConsoleColor.Blue;

            if (num % 2 == 1)
            {
                Console.WriteLine("IMPAR");
            }
            else
            {
                Console.WriteLine("PAR");
            }
            Console.ResetColor();
        }
    }
}