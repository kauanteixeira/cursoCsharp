using System;
using System.Globalization;

namespace PalavraThis
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Qtde;

        /*
            This para diferenciar atributos de variaveis locais, e referênciar outro construtor em um construtor.
        */
        public Produto ()
        {
            Qtde = 3;
        }
        public Produto(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
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
                + ", " 
                + Qtde
                + " unidade"
                + ", Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }


    }
}