using System;

namespace ExerciciosCsharp.Exercicios
{
    public class Exercicio0026
    {
        public static void Executar()
        {
            Console.Write("Qual é a velocidade atual do carro? ");
            double.TryParse(Console.ReadLine(), out double vel);

            if (vel > 80)
            {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("MULTADO! Você excedeu o limite permitido que é de 80Km/h");
               double multa = (vel - 80) * 7.00;
               Console.Write("Você deve pagar uma multa de ");
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("R${0}!", multa);
               Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Tenha um bom dia! Dirija com segurança!");
                Console.ResetColor();
            }
        }
    }
}