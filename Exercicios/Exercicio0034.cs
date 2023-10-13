using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0034
    {
        public static void Executar()
        {
            DateTime date = DateTime.Now;

            Console.Write("Ano de nascimento: ");
            int.TryParse(Console.ReadLine(), out int ano);

            int idade = date.Year - ano;

            Console.WriteLine("Quem nasceu em {0} tem {1} anos em {2}.", ano, idade, date.Year);

            if (idade < 18)
            {
                Console.WriteLine("Ainda faltam {0} anos para o alistamento", 18 - idade);
                Console.WriteLine("Seu alistamento será em {0}.", date.Year + (18 - idade));
            }
            else if (idade > 18)
            {
                Console.WriteLine("Você já deveria ter se alistado há {0} anos.", idade - 18);
                Console.WriteLine("Seu alistamento foi em {0}.", date.Year - (idade - 18));
            }
            else
            {
                Console.WriteLine("Você tem que se alistar IMEDIATAMENTE!");
            }

        }
    }
}