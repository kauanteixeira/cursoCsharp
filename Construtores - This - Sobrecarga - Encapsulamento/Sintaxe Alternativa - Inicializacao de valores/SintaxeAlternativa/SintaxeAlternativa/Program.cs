using System;
using System.Globalization;
using SintaxeAlternativa;

namespace MyCode
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                Funciona se a classe não possuir construtores implementados:

                Produto p = new Produto()
                {
                    Nome = "Tv",
                    Preco = 900.00,
                    Quantidade = 5
                };
            */

            Produto p = new Produto("Celular", 1500.00, 10);

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}