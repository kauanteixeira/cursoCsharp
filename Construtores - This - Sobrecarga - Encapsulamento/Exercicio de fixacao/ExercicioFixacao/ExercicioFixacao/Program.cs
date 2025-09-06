using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria cliente;

            Console.Write("Entre o número da conta: ");
            if (!int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("Número inválido! Encerrando o programa...");
                return;
            }

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            string confirmacaoDepositoInicial = Console.ReadLine().ToLower();

            if (confirmacaoDepositoInicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                cliente = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("\nDados da conta:");
            Console.WriteLine(cliente);

            Console.Write("\nEntre um valor para depósito: ");
            cliente.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("\nConta atualizada: ");
            Console.WriteLine(cliente);

            Console.Write("\nEntre um valor para saque: ");
            cliente.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cliente);
        }
    }
}