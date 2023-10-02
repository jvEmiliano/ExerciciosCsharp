using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0015
    {
        public static void Executar()
        {
            Console.Write("Digite um valor: ");
            double.TryParse(Console.ReadLine(), out double numero);

            int numeroInteiro = (int)numero;
            Console.WriteLine("O valor digitado foi {0} e a sua porção inteira é {1}", numero, numeroInteiro);
        }
    }
}