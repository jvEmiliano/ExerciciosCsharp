using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0008
    {
        public static void Executar()
        {
            Console.Write("Digite um número para ver sua tabuada: ");
            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine("------------");
            
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("------------");
        }
    }
}