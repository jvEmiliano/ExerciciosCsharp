using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0014
    {
        public static void Executar()
        {
            Console.Write("Quantos dias alugados? ");
            int.TryParse(Console.ReadLine(), out int diasAlugados);

            Console.Write("Quantos Km rodados? ");
            double.TryParse(Console.ReadLine(), out double kmRodados);

            double totalAPagar = diasAlugados * 60 + kmRodados * 0.15;
            Console.WriteLine($"O total a pagar é de R${totalAPagar.ToString("F2")}");
        }
    }
}