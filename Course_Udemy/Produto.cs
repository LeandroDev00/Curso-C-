using System;
using System.Globalization;

namespace Estoque
{
	class Produto
	{
		private string? _nome;
		public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco)
		{
			this._nome = nome;
			this.Preco = preco;
		}

		public string Nome
		{
			get { 
				return _nome; 
			}
			set {
                if (value != null && value.Length >= 2){
                    _nome = value;
                }
            }
		}


		public double ValorTotalEmEstoque()
		{
			return  Preco * Quantidade;
		}

		public void AdicionarProdutos(int quantidade)
		{
			Quantidade += quantidade;
		}

		public void RemoverProdutos(int quantidade)
		{
			Quantidade -= quantidade;
		}

		public override string ToString()
		{
			return _nome 
				+ ", $" 
				+ Preco.ToString("F2", CultureInfo.InvariantCulture)
				+ ", "
				+ Quantidade + " Unidades, Total: $ "
				+ ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
		}
	}
}