using System;
using ClassExercises04;

namespace MyCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto em R$: ");
            f.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine($"Funcionário: {f}");

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double aumento = double.Parse(Console.ReadLine());
            f.AumentarSalario(aumento);

            Console.WriteLine($"Dados atualzados: {f}");

        }
    }
}
