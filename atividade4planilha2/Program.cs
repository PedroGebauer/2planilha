using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        var br = new CultureInfo("pt-BR");

        Console.Write("Informe o valor presente: ");
        decimal valorPresente = decimal.Parse(Console.ReadLine());

        Console.Write("Informe a taxa de juros (% ao mês): ");
        decimal taxaJuros = decimal.Parse(Console.ReadLine());

        Console.Write("Informe o período em meses: ");
        int periodoMeses = int.Parse(Console.ReadLine());

        decimal percentualJuros = taxaJuros / 100m;
        int mesResgate = 5;
        int periodoAM = 0;

        Console.WriteLine();
        Console.WriteLine("valor presente\t taxa de juros\t mes\t rendimento\t renda liquida\t renda acumulada\t resgate\t SALDO");

        for (int mes = 1; mes <= periodoMeses; mes++)
        {
            periodoAM++;

            decimal rendimento = valorPresente * (1m + percentualJuros * periodoAM);
            decimal rendaLiquida = rendimento - valorPresente;
            decimal resgate = (mes == mesResgate) ? rendaLiquida : 0m;
            decimal saldo = rendimento - resgate;

            decimal rendaAcumulada = (mes == mesResgate) ? saldo : rendimento;

            Console.WriteLine(string.Format(
                br,
                "{0:C2}\t {1:F2}%\t\t {2}\t {3:C2}\t {4:C2}\t {5:C2}\t\t {6:C2}\t {7:C2}",
                valorPresente, taxaJuros,
                (mes == mesResgate ? mesResgate : periodoAM),
                rendimento, rendaLiquida, rendaAcumulada, resgate, saldo
            ));


            if (mes == mesResgate)
            {
                valorPresente = saldo;
                periodoAM = 0;
            }
        }
    }
}