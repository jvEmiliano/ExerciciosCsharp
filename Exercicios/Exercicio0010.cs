using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0010
    {
        public static void Executar()
        {
            Console.Write("Largura da parede: ");
            float.TryParse(Console.ReadLine(), out float largura);

            Console.Write("Altura da parede: ");
            float.TryParse(Console.ReadLine(), out float altura);

            float area = largura * altura;

            Console.WriteLine($"Sua parede tem a dimensão de {largura}x{altura} e sua área é de {area}m².");
            Console.WriteLine($"Para pintar essa parede você precisará de {area / 2}l de tinta.");
        }
    }
}