using System;
using System.Globalization;
using Conta;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente = new ContaBancaria();

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.NumConta(numero);

            Console.Write("Entre o titular da conta: ");
            cliente.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string operacao = Console.ReadLine();

            if (operacao.ToLower() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                cliente.Deposito(depositoInicial);
                Console.WriteLine(cliente);
            }
            else
            {
                Console.WriteLine(cliente);
            }

            Console.WriteLine("Entre um valor para depósito: ");
            double quantiaDeposito = double.Parse(Console.ReadLine());
            cliente.Deposito(quantiaDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);

            Console.WriteLine("Entre um valor para saque: ");
            double quantiaSaque = double.Parse(Console.ReadLine());
            cliente.Saque(quantiaSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
        }
    }
}