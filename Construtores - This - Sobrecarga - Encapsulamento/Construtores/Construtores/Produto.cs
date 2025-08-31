using System;
using System.Globalization;

namespace Construtores
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        public Produto(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public double ValorTotalEmEstoque()
        {
            return Qtde * Preco;
        }
        public void AdicionarProdutos(int value)
        {
            Qtde += value;
        }
        public void RemoverProdutos(int value)
        {
            Qtde -= value;
        }
        public override string ToString()
        {
            return
                Nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Qtde
                + " unidade"
                + ", Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }


    }
}