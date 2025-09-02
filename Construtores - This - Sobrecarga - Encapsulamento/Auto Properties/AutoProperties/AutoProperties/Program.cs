using System;
using System.Globalization;
using PropriedadesAutoimplementadas;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int qtde = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, qtde);

            Console.WriteLine($"Dados do produto: {p}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int v = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(v);

            Console.WriteLine($"Dados atualizados: {p}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int v1 = int.Parse(Console.ReadLine());

            p.RemoverProdutos(v1);

            Console.WriteLine("Faça uma alteração no nome do produto: ");
            string novoNome = Console.ReadLine();
            p.Nome = novoNome;

            Console.WriteLine($"Dados atualizados: {p}");



        }
    }
}
