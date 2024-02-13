using System.Globalization;
using Estoque;

namespace App
{
    class Program
    {
        static void Main()
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
            /*
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.TrianguloClasse();
            double areaY = y.TrianguloClasse();

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }
            else
            {
                Console.WriteLine("Maior area: Y");
            }
            Console.ReadLine();
            */
        }
    }
}