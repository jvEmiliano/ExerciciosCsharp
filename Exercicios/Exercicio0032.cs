using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0032
    {
        public static void Executar()
        {
            Console.Write("Digite um número inteiro: ");
            int.TryParse(Console.ReadLine(), out int num);

            Console.WriteLine("Escolha uma das bases para conversão:");
            Console.WriteLine("[ 1 ] converter para BINÁRIO\n[ 2 ] converter para OCTAL\n[ 3 ] converter para HEXADECIMAL");

            Console.Write("Sua opção: ");
            int.TryParse(Console.ReadLine(), out int opcao);

            switch (opcao)
            {
                case 1:
                    string binario = Convert.ToString(num, 2);
                    Console.WriteLine("{0} convertido para BINÁRIO é igual a {1}", num, binario);
                    break;
                case 2:
                    string octal = Convert.ToString(num, 8);
                    Console.WriteLine("{0} convertido para OCTAL é igual a {1}", num, octal);
                    break;
                case 3:
                    string hexadecimal = Convert.ToString(num, 16);
                    Console.WriteLine("{0} convertido para HEXADECIMAL é igual a {1}", num, hexadecimal);
                    break;
            }
        }
    }
}