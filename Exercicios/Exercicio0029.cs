using System;

namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0029
    {
        public static void Executar()
        {
            int[] numeros = new int[3];

            Console.Write("Primeiro valor: ");
            numeros[0] = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            numeros[1] = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            numeros[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("O menor valor digitado foi {0}", numeros.Min());
            Console.WriteLine("O maior valor digitado foi {0}", numeros.Max());
        }
    }
}       