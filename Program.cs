using System;
using System.Collections.Generic;

using ExerciciosCsharp.Exercicios;

namespace ExerciciosCsharp;

class Program
{
    static void Main(string[] args)
    {
        var central = new CentralDeExercicios(new Dictionary<string, Action>() {
            {"0001 - Hello World", Exercicio0001.Executar},
            {"0002 - Respondendo ao Usuário", Exercicio0002.Executar},
            {"0003 - Somando dois números", Exercicio0003.Executar},
            {"0004 - Antecessor e Sucessor", Exercicio0004.Executar},
            {"0005 - Dobro, Triplo, Raiz Quadrada", Exercicio0005.Executar},
            {"0006 - Média Aritmética", Exercicio0006.Executar},
            {"0007 - Conversor de Medidas", Exercicio0007.Executar},
            {"0008 - Tabuada", Exercicio0008.Executar},
            {"0009 - Conversor de Moedas", Exercicio0009.Executar},
            {"0010 - Pintando Parede", Exercicio0010.Executar},
            {"0011 - Calculando Descontos", Exercicio0011.Executar},
            {"0012 - Reajuste Salarial", Exercicio0012.Executar},
            {"0013 - Conversor de Temperaturas", Exercicio0013.Executar},
            {"0014 - Aluguel de Carros", Exercicio0014.Executar},
            {"0015 - Quebrando um número", Exercicio0015.Executar},
            {"0016 - Catetos e Hipotenusa", Exercicio0016.Executar},
            {"0017 - Seno, Cosseno e Tangente", Exercicio0017.Executar},
            {"0018 - Sorteando um item na lista", Exercicio0018.Executar},
            {"0019 - Analisador de Textos", Exercicio0019.Executar},
            {"0020 - Separando dígitos de um número", Exercicio0020.Executar},
            {"0021 - Verificando as primeiras letras de um texto", Exercicio0021.Executar},
            {"0022 - Procurando uma string dentro de outra", Exercicio0022.Executar},
            {"0023 - Primeira e última ocorrência de uma string", Exercicio0023.Executar},
            {"0024 - Primeiro e último nome de uma pessoa", Exercicio0024.Executar},
            {"0025 - Jogo da Adivinhação v.1.0", Exercicio0025.Executar},
            {"0026 - Radar eletrônico", Exercicio0026.Executar},
            {"0027 - Par ou Ímpar?", Exercicio0027.Executar},
        });

        central.SelecionarEExecutar();
    }
}
                    