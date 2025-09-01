using System.Globalization;

namespace Propriedades
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

        public string Nome
        {
            get{ return _nome; }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public double Preco
        {
            get { return _preco; }
        }

        public int Qtde
        {
            get { return _qtde; }
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