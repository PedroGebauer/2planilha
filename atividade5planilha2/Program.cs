using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problema5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            double valorFinal = 7390.61;

            double taxaJurosMensal = 1.25;

            int tempoAnos = 2;

            double taxaAnualEfetiva = Math.Pow(1 + (taxaJurosMensal / 100), 12) - 1;

            double valorPresente = valorFinal / Math.Pow(1 + taxaAnualEfetiva, tempoAnos);


            Console.WriteLine($"Valor Futuro (VF): R${valorFinal:F2}");
            Console.WriteLine($"Taxa mensal: {taxaJurosMensal}% a.m.");
            Console.WriteLine($"Taxa anual efetiva: {taxaAnualEfetiva * 100:F2}% a.a.");
            Console.WriteLine($"Período: {tempoAnos} anos");
            Console.WriteLine($"Valor Presente (VP): R${valorPresente:F2}");

            Console.ReadLine();
        }
    }
}