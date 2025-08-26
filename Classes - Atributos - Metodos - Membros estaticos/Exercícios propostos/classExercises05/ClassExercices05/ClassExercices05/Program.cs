using System;
using System.Globalization;
using ClassExercices05;

namespace MyCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do aluno: ");

            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");

            aluno.N1 = double.Parse(Console.ReadLine());
            aluno.N2 = double.Parse(Console.ReadLine());
            aluno.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");

            if (aluno.Aprovado())
                Console.WriteLine("APROVADO");
            else
                Console.WriteLine($"REPROVADO \nFALTARAM {aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
        }
    }
}