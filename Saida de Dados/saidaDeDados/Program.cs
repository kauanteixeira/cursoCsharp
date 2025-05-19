using System;
using System.Globalization;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char genero = 'M';
            string nome = "Kauan";
            int idade = 19;
            double saldo = 10.129;

            //Diferença entre WriteLine e Write

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("--------------------");

            Console.Write("Bom dia!");
            Console.Write("Boa tarde!");
            Console.Write("Boa noite!");
            Console.WriteLine("--------------------");

            //Imprimindo dados e formatação de dados

            Console.WriteLine(genero);
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2")); //ToString para definir quantas casas decimais aparece após a , ou .
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //CultureInfo.InvariantCulture para deixar a formatação padrão, ignora a formatação do pais

        }
    }
}