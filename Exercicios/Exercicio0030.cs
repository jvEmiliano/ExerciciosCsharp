using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0030
    {
        public static void Executar()
        {
            Console.Write("Qual o salário do funcionário? R$");
            double.TryParse(Console.ReadLine(), out double salario);

            double salarioComAumento;

            if (salario > 1250)
            {
                salarioComAumento = salario + ((salario * 10) / 100);
            }
            else
            {
                salarioComAumento = salario + ((salario * 15) / 100);
            }

            Console.WriteLine("Quem ganhava {0} passa a ganhar R${1} agora.", salario, salarioComAumento);
        }
    }
}