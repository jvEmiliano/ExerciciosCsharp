using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0031
    {
        public static void Executar()
        {
            Console.Write("Valor da casa: R$");
            double.TryParse(Console.ReadLine(), out double valorCasa);

            Console.Write("Salário do comprador: R$");
            double.TryParse(Console.ReadLine(), out double salarioComprador);

            Console.Write("Quantos anos de financiamento? ");
            int.TryParse(Console.ReadLine(), out int anosFinan);

            double prestacaoMensal = valorCasa / (anosFinan * 12);
            double porcetagem = (salarioComprador * 30) / 100;

            Console.WriteLine("Para pagar uma casa de R${0} em {1} anos a prestação será de R${2}", valorCasa.ToString("F2"), anosFinan, prestacaoMensal.ToString("F2"));

            if (prestacaoMensal > porcetagem)
            {
                Console.WriteLine("Empréstimo NEGADO!");
            }
            else
            {
                Console.WriteLine("Empréstimo pode ser CONCEDIDO!");
            }
        }
    }
}