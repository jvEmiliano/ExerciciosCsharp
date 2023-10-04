using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0028
    {
        public static void Executar()
        {
            Console.Write("Qual é a distância da sua viagem? ");
            double.TryParse(Console.ReadLine(), out double distancia);

            Console.WriteLine("Você está prestes a começar uma viagem de {0}Km.", distancia);

            double preco = 0;

            if (distancia <= 200)
            {
                preco += distancia * 0.50;
            }
            else
            {
                preco += distancia * 0.45;
            }

            Console.WriteLine("E o preço da sua passagem será de R${0}", preco);
        }
    }
}