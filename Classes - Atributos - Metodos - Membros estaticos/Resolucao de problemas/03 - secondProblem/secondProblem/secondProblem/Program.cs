using System;
using System.Globalization;
using secondProblem;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Qtde = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int v = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(v);

            Console.WriteLine($"Dados atualizados: {p}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int v1 = int.Parse(Console.ReadLine());

            p.RemoverProdutos(v1);

            Console.WriteLine($"Dados atualizados: {p}");
        }
    }
}