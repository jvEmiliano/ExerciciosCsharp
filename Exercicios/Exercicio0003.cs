using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0003
    {
        public static void Executar()
        {
            Console.Write("Digite um valor: ");
            int.TryParse(Console.ReadLine(), out int valor1);

            Console.Write("Digite outro valor: ");
            int.TryParse(Console.ReadLine(), out int valor2);

            int resultado = valor1 + valor2;
            Console.WriteLine("A soma entre {0} e {1} é igual a {2}!", valor1, valor2, resultado);
        }
    }
}