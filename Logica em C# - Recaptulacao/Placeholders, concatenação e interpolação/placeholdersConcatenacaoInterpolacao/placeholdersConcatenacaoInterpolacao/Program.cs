using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Kauan";
            int idade = 19;
            double saldo = 10.35624;

            //Placeholder
            Console.WriteLine("{0} tem {1} anos e possui o saldo de {2:F2} na conta!", nome, idade, saldo);

            //Interpolação
            Console.WriteLine($"{nome} tem {idade} anos e possui o saldo de {saldo} na conta!");


            //Concatenação
            Console.WriteLine(nome + " tem " + idade + " anos" + " e possui o saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " na conta!");

        }
    }
}