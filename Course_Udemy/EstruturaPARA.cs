using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;
using System;

namespace Course_Udemy
{
    public class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double TrianguloClasse()
        {
            double p = (A + B + C) / 2.0;
            double area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }
    }

    public class EstruturaPARA
    {

        public static void Tabuada(int N)
        {
            //int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                int produto = i * N;
                Console.WriteLine(i + " x " + N + " = " + produto);
            }
        }

        public static void Vetores()
        {
            Console.WriteLine("Digite um numero inteiro:");
            double[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new double[N];

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }

        public static void Vetnegativo()
        {
            int N;
            int[] vet;

            Console.WriteLine("Digite um numero:");
            N = int.Parse(Console.ReadLine());
            vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++)
            {
                if (vet[i] < 0)
                {
                    Console.WriteLine(vet[i]);
                }
            }
        }

        public static void Vetreais()
        {
            double[] vet;
            int N;

            Console.WriteLine("Digite a quantidade para adicionar:");
            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            Console.WriteLine("Digite um valor decimal , e o próximo com espaço: 8.0 4.0");
            string[] s = Console.ReadLine().Split(' ');

            Console.WriteLine("-------------------------------------");

            for (int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Lista vetores: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double media = 0.0, soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma = vet[i] + soma;
                media = soma / N;
            }
            Console.WriteLine("Soma dos Vetores " + soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Media dos Vetores " + media.ToString("F2", CultureInfo.InvariantCulture));

        }

        public static void Vetpessoa()
        {
            int N;

            Console.WriteLine("Digite um numero para quantidade de pessoas:");
            N = int.Parse(Console.ReadLine());


            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            Console.WriteLine("Digite um nome - idade - altura:");
            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = s[0];
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("------------------------------");
            double soma = 0.0;
            for (int i = 0; i < N; i++)
            {
                soma += altura[i];
            }
            double mediaalt = soma / N;
            Console.WriteLine("Altura média: " + mediaalt.ToString("F2", CultureInfo.InvariantCulture));

            //Calculo da porcentagem
            double porcen = 0.0;
            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                if (idade[i] < 16)
                {
                    cont++;
                }
                porcen = cont * 100 / N;
            }
            Console.WriteLine("Pessoas com menos de 16  anos: " + porcen.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }

    public class Matriz
    {
        public static void Matrizes()
        {
            int M, N;

            string[] s1 = Console.ReadLine().Split(' ');
            M = int.Parse(s1[0]);
            N = int.Parse(s1[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        public static void MatrizDiagonal()
        {
            int N, cont = 0;

            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);
        }

        //Matrizes Exercicio proposto:

        public static void Matriz1()
        {
            /*
             1) Ler dois números M e N, e depois ler uma matriz MxN de números inteiros, conforme exemplo. Em seguida, mostrar
                na tela somente os números negativos da matriz.
                Entrada:
                A entrada contém os números M e N na mesma linha, depois os dados da matriz.
                Saída:
                A saída contém uma mensagem e depois os números negativos da matriz, conforme exemplo.*/

            int M, N;

            string[] mat = Console.ReadLine().Split(' ');

            M = int.Parse(mat[0]);
            N = int.Parse(mat[1]);

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] s = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                }

            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }

    public class ProvaProg
    {
        public static void Exercicio1()
        {
            int codpeca, codpeca2, numpeca, numpeca2;
            double vlrpeca, vlrpeca2, vlrpagar;

            string[] vetor;
            string[] vetorr;

            Console.WriteLine("Digite codigo, quantidade, valor:");
            vetor = Console.ReadLine().Split(' ');
            vetorr = Console.ReadLine().Split(' ');

            codpeca = int.Parse(vetor[0]);
            numpeca = int.Parse(vetor[1]);
            vlrpeca = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            codpeca2 = int.Parse(vetorr[0]);
            numpeca2 = int.Parse(vetorr[1]);
            vlrpeca2 = double.Parse(vetorr[2], CultureInfo.InvariantCulture);

            vlrpagar = (numpeca * vlrpeca) + (numpeca2 * vlrpeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + vlrpagar.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

        public static void Exercicio2_1()
        {
            int codpro, qtd;
            double total;
            string[] vetor = Console.ReadLine().Split(' ');

            codpro = int.Parse(vetor[0]);
            qtd = int.Parse(vetor[1]);

            if (codpro == 1)
            {
                total = qtd * 4.00;
                Console.WriteLine("Cachorro Quente");
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codpro == 2)
            {
                total = qtd * 4.50;
                Console.WriteLine("X-Salada");
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codpro == 3)
            {
                total = qtd * 5.00;
                Console.WriteLine("X-Bacon");
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codpro == 4)
            {
                total = qtd * 2.00;
                Console.WriteLine("Torrada simples");
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            if (codpro == 5)
            {
                total = qtd * 1.50;
                Console.WriteLine("Refrigerante");
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
        }

        public static void Exercicio3_2()
        {
            int num, x, cont_in = 0, cont_out = 0;

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    cont_in++;
                }
                else if (x < 10 || x > 20)
                {
                    cont_out++;
                }
            }
            Console.WriteLine(cont_in + " in");
            Console.WriteLine(cont_out + " out");

            Console.ReadLine();
        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }

    public class ClassesExemplo
    {
        public static void ProblemaExemplo()
        {
            /*Digite um número e mostrar sua raiz quadrada com três casas decimais,
             depois repetir o procedimento. Quando o usuário digitar um número negativo
            (podendo inclusive ser na primeira vez), mostrar uma mensagem "Numero negativo" e
            terminar o programa.*/

            int N;
            double raiz;

            Console.Write("Digite um numero:");
            N = int.Parse(Console.ReadLine());

            while (N >= 0)
            {
                raiz = Math.Sqrt(N);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

                Console.Write("Digite outro numero:");
                N = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo !");

            Console.ReadLine();
        }

        public static void ProblemaTriangulo()
        {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triangulo X:");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Area de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior area: Y");
            }
            else
            {
                Console.WriteLine("Maior area: X");
            }
            Console.ReadLine();
        }
    }
}
