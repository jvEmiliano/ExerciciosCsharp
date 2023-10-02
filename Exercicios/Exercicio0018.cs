using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0018
    {
        public static void Executar()
        {
            Random random = new Random();

            string[] alunos = new string[4];

            for(int i = 0; i < 4; i++)
            {
                Console.Write($"{i + 1}° aluno: ");
                alunos[i] = Console.ReadLine();
            }

            string alunoSorteado = alunos[random.Next(0, 4)];
            Console.WriteLine($"O aluno escolhido foi {alunoSorteado}");
        }
    }
}