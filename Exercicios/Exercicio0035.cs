using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0035
    {
        public static void Executar()
        {
            Console.Write("Primeira nota: ");
            float.TryParse(Console.ReadLine(), out float nota1);

            Console.Write("Segunda nota: ");
            float.TryParse(Console.ReadLine(), out float nota2);

            float media = (nota1 + nota2) / 2;

            Console.WriteLine($"Tirando {nota1} e {nota2} a média do aluno é {media}");

            if (media < 5.0)
            {
                Console.WriteLine("O aluno está REPROVADO.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("O aluno está em RECUPERAÇÃO.");
            }
            else
            {
                Console.WriteLine("O aluno está APROVADO.");
            }

        }
    }
}