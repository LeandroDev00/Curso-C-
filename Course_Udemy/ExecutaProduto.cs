using System;
using System.Globalization;
using Estoque;

namespace Executar
{
    class ExecutarProduto
    {
        public static void RunProduto()
        {
            Console.WriteLine("Iniciar edição no estoque ? SIM / NAO");
            string res = Console.ReadLine();

            while (res == "SIM" || res == "sim")
            {
                Console.WriteLine("Digite os dados do produto: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                /*
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                */

                Produto p = new Produto(nome, preco);

                Console.WriteLine("Dados do Produto: " + p);

                Console.WriteLine("--------------------------------------------------------");

                Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
                int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.AdicionarProdutos(qtd);

                Console.WriteLine();

                Console.WriteLine("Dados atualizados: " + p);

                Console.WriteLine("----------------------------------------------------------");

                Console.Write("Digite o numero de produtos a ser removido do estoque: ");
                qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p.RemoverProdutos(qtd);

                Console.WriteLine();

                Console.WriteLine("Dados Atualizados: " + p);

                Console.WriteLine("-----------------------------------------------------------");

                Console.WriteLine();
                Console.WriteLine("Deseja alterar outro produto ? Digite SIM ou NAO");
                res = Console.ReadLine();

            }
        }
    }
}