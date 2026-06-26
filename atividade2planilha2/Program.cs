using System;

class Program
{
    static void Main(string[] args)
    {

Console.WriteLine("Informe o valor presente");
decimal valorPresente = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a taxa de juros %");
decimal taxaJuros = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe o perido em meses: ");
int periodoMeses = int.Parse(Console.ReadLine());

decimal percentualJuros = taxaJuros / 100;

Console.WriteLine("\n------------ Tabela de Rendimento ------------\n");

Console.WriteLine("Rendimento Mensal (a.m.)");
Console.WriteLine("ValorP\tTaxa%\tMes\tRendimento\tRendimento Liquido");

decimal valorFinal = valorPresente;

decimal RendimentoLiquido = 0;

for (int mes = 1; mes <= periodoMeses; mes++)
{
    valorFinal = valorFinal * (1 + percentualJuros);
    RendimentoLiquido = valorFinal - valorPresente;

    Console.WriteLine($"{valorPresente}\t{taxaJuros}\t{mes}\t{valorFinal:F2}\t\t{RendimentoLiquido:F2}");


}

    }
}