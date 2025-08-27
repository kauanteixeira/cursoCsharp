using System;
using System.Globalization;
using StaticMembers;

namespace MyCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = R$ {Conversor.DolarReal(cotacao, quantia).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}