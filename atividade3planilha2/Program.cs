using System;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Informe o valor presente");
decimal valorPresente = decimal.Parse(Console.ReadLine());    

Console.WriteLine("Informe a taxa de juros %");
decimal taxaJuros = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe o perido em anos: ");
int periodoAnos = int.Parse(Console.ReadLine());


decimal percentualJuros = taxaJuros / 100;  

Console.WriteLine( "------------ Tabela de Rendimento ------------");

Console.WriteLine("Rendimento Mensal (a.m.)");
Console.WriteLine("ValorP\tTaxa%\tAno\tValorF(R$)\tRendimento Liquido");

decimal valorFinal = valorPresente;

decimal RendimentoLiquido = 0;
int periodoMeses = periodoAnos * 12;
for (int ano = 1; ano <= periodoAnos; ano++)
{
    valorFinal = valorFinal * (1 + percentualJuros);
    RendimentoLiquido = valorFinal - valorPresente; 

    Console.WriteLine($"{valorPresente}\t{taxaJuros}\t{ano}\t{valorFinal:F2}\t\t{RendimentoLiquido:F2}");

    
}
    }
}