using System.Globalization;

namespace Encapsulamento
{
    public class Produto
    {
        private string _nome;
        private double _preco;
        private int _qtde;

        public Produto(string nome, double preco, int qtde)
        {
            _nome = nome;
            _preco = preco;
            _qtde = qtde;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }

        public int GetQtde()
        {
            return _qtde;
        }

        public double ValorTotalEmEstoque()
        {
            return _qtde * _preco;
        }
        public void AdicionarProdutos(int value)
        {
            _qtde += value;
        }
        public void RemoverProdutos(int value)
        {
            _qtde -= value;
        }
        public override string ToString()
        {
            return
                _nome
                + ", R$"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _qtde
                + " unidade"
                + ", Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
            ;
        }


    }
}