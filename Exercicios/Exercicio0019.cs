using System;

namespace ExerciciosCsharp.Exercicios
{
    class Exercicio0019
    {
        public static void Executar()
        {
            Pessoa pessoa = new Pessoa();
            Console.Write("Digite seu nome completo: ");
            pessoa.nome = Console.ReadLine().Trim();

            Console.WriteLine("Analisando seu nome...");

            pessoa.NomeEmMaiusculo();
            pessoa.NomeEmMinusculo();
            pessoa.QuantLetras();
            pessoa.PrimeiroNome();
        }
    }
    class Pessoa
    {
        public string nome;

        public void NomeEmMaiusculo()
        {
            Console.WriteLine($"Seu nome em maiúsculas é {nome.ToUpper()}");
        }
        public void NomeEmMinusculo()
        {
            Console.WriteLine($"Seu nome em minúsculas é {nome.ToLower()}");
        }
        public void QuantLetras()
        {
            int quant = 0;
            char[] nomeArray = nome.ToArray();
            foreach(char letra in nomeArray)
            {
                if(letra != ' ')
                {
                    quant++;
                }
            }
            Console.WriteLine($"Seu nome tem ao todo {quant} letras");
        }
        public void PrimeiroNome()
        {
            string[] nomeArray = nome.Split(" "); 
            Console.WriteLine($"Seu primeiro nome é {nomeArray[0]} e ele tem {nomeArray[0].Length} letras");
        }
    }
}