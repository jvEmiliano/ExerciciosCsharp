using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0012
    {
        public static void Executar()
        {
            Console.Write("Qual é o salário do Funcionário? R$");
            decimal.TryParse(Console.ReadLine(), out decimal salario);

            decimal aumento = salario + salario * 15 / 100;
            Console.WriteLine($"Um funcionário que ganhava R${salario}, com 15% de aumento, passa a receber R${aumento.ToString("F2")}");
        }
    }
}