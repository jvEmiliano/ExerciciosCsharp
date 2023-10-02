using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0004
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine($"Analisando o valor {numero}, seu antecessor é {numero - 1} e o sucessor é {numero + 1}");
        }
    }
}