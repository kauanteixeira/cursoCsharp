using System.Globalization;

namespace PropriedadesAutoimplementadas
{
    public class Produto
    {
        private string _nome;

        /*
            É uma forma simplificada de se declarar propriedades que não
            necessitam lógicas particulares para as operações get e set. 
        */

        public double Preco { get; private set; }
        public int Qtde { get; private set; }

        public Produto(string nome, double preco, int qtde)
        {
            _nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
                _nome
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