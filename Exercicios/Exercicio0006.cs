using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0006
    {
        public static void Executar()
        {
            Console.Write("Primeira nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota1);

            Console.Write("Segunda nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota2);

            double media = (nota1 + nota2) / 2;
            Console.WriteLine("A média entre {0} e {1} é igual a {2}", nota1, nota2, media);
        }
    }
}