using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0009
    {
        public static void Executar()
        {
            Console.Write("Quanto dinheiro você tem na carteira? R$");
            float.TryParse(Console.ReadLine(), out float dinheiro);

            float conversao = dinheiro / 5.01f;
            Console.WriteLine($"Com R${dinheiro} você pode comprar US${conversao.ToString("F2")}");
        }
    }
}