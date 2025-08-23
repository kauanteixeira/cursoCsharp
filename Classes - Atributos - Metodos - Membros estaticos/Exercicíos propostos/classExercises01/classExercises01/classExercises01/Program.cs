using System;
using InfoEmployee;

namespace MyCompiler
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome:");
            e1.Name = Console.ReadLine();
            Console.Write("Salário:");
            e1.Wage = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome:");
            e2.Name = Console.ReadLine();
            Console.Write("Salário:");
            e2.Wage = double.Parse(Console.ReadLine());

            double average = AverageSalary(e1.Wage, e2.Wage);

            Console.WriteLine("Salário médio = " + average);
        }

        static double AverageSalary(double w1, double w2)
        {
            return (w1 + w2) / 2;
        }
    }
}