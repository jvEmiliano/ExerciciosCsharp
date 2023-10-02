using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0005
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int numero);

            Console.WriteLine("O dobro de {0} vale {1}.", numero, numero * 2);
            Console.WriteLine("O tripo de {0} vale {1}.", numero, numero * 3);
            Console.WriteLine("A raiz quadrada de {0} é igual a {1}.", numero, Math.Sqrt(numero).ToString("F2"));
        }
    }
}