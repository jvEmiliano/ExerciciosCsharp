using System;

namespace ExerciciosCsharp.Exercicios
{
  class Exercicio0036
  {
    public static void Executar()
    {
      Console.Write("Ano de Nascimento: ");
      int.TryParse(Console.ReadLine(), out int anoN);

      DateTime date = DateTime.Now;

      //int idade = date.Year - anoN;
      int idade = 2017 - anoN;

      Console.WriteLine("O atleta tem {0} anos.", idade);

      if (idade <= 9)
      {
        Console.WriteLine("Classificação: MIRIM");
      }
      else if (idade <= 14)
      {
        Console.WriteLine("Classificação: INFANTIL");
      }
      else if (idade <= 19)
      {
        Console.WriteLine("Classificação: JÚNIOR");
      }
      else if (idade <= 25)
      {
        Console.WriteLine("Classificação: SÊNIOR");
      }
      else
      {
        Console.WriteLine("Classificação: MASTER");
      }

    }
  }
}
