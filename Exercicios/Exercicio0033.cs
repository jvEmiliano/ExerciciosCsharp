using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0033
    {
        public static void Executar()
        {
            Console.Write("Primeiro número: ");
            int.TryParse(Console.ReadLine(), out int num1);

            Console.Write("Segundo número: ");
            int.TryParse(Console.ReadLine(), out int num2);

            if (num1 > num2)
            {
                Console.WriteLine("O PRIMEIRO valor é maior");
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O SEGUNDO valor é maior");
            }
            else
            {
                Console.WriteLine("Os dois valores são IGUAIS");
            }
        }
    }
}