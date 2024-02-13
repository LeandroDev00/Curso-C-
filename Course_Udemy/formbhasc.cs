using System.Globalization;

namespace FormBhas{

    class Form {
       
        public static void Multiplo() 
        {
            int m, n;
            string[] vet;

            vet = Console.ReadLine().Split(' ');

            m = int.Parse(vet[0], CultureInfo.InvariantCulture);
            n = int.Parse(vet[1], CultureInfo.InvariantCulture);

            if (m % n == 0 || n % m == 0) 
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são multiplos");
            }
        }

        public static void Lanche()
        {
            int cod, qtd;
            double total;
            string[] vet;

            Console.WriteLine("Digite o código do Lanche(1, 2, 3, 4, 5)/ Quantidade:");
            vet = Console.ReadLine().Split(' ');

            cod = int.Parse(vet[0], CultureInfo.InvariantCulture);
            qtd = int.Parse(vet[1], CultureInfo.InvariantCulture);

            switch (cod)
            {
                case 1:
                    total = qtd * 4.00;
                    Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
                case 2:
                    total = qtd * 4.50;
                    Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
                case 3:
                    total = qtd * 5.00;
                    Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
                case 4:
                    total = qtd * 2.00;
                    Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
                case 5:
                    total = qtd * 1.50;
                    Console.WriteLine("Total: R$" + total.ToString("F2"), CultureInfo.InvariantCulture);
                    break;
            }

        }

        public static void TesteSelecao()
        {
            /*
             Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, 
            e a soma de C com D for maior que a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par 
            escrever a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".
             */
            int A, B, C, D, soma1, soma2;
            string[] vet;

            Console.WriteLine("Digite os valores A, B, C, D");
            vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0], CultureInfo.InvariantCulture);
            B = int.Parse(vet[1], CultureInfo.InvariantCulture);
            C = int.Parse(vet[2], CultureInfo.InvariantCulture);
            D = int.Parse(vet[3], CultureInfo.InvariantCulture);

            soma1 = C + D;
            soma2 = A + B;
            int par = A % 2;

            if (B > C)
            {
                if(D > A && soma1 > soma2)
                {
                    if (C > 0 && D > 0)
                    {
                        if (par == 0)
                        {
                            Console.WriteLine("Valores aceitos");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }

        public static void FormBhask()
                    {
                        /*Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara.
                         Se não for possivél calcular as raízes, mostre a mensagem correspondente "impossivel calcular",
                        caso haja uma divisão por 0 ou raiz de numero negativo.*/

                        double a, b, c, delta, R1, R2;
                        string[] vet;

                        Console.WriteLine("Digite o valor A, B, C:");

                        vet = Console.ReadLine().Split(' ');

                        a = double.Parse(vet[0], CultureInfo.InvariantCulture);

                        b = double.Parse(vet[1], CultureInfo.InvariantCulture);

                        c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                        delta = Math.Pow(b, 2.0) - 4 * a * c;

                        if (delta < 0.0 || a == 0)
                        {
                            Console.WriteLine("IMPOSSIVEL CALCULAR!");
                        }
                        else
                        {
                            R1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                            R2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                            Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                            Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
                        }


                    }

        public static void NotasAluno()
        {

            double n1, n2, nota_final;

            Console.WriteLine("Digite nota 1:");
            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite nota 2");
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nota_final = n1 + n2;

            if (nota_final < 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + nota_final.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + nota_final.ToString("F1", CultureInfo.InvariantCulture));
            }

        }

        public static void Area()
        {
            /*
             1012
            Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
            a) a área do triângulo retângulo que tem A por base e C por altura.
            b) a área do círculo de raio C. (pi = 3.14159)
            c) a área do trapézio que tem A e B por bases e C por altura.
            d) a área do quadrado que tem lado B.
            e) a área do retângulo que tem lados A e B.
             */
            double A, B, C, pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2.0;
            double circulo = (pi * (Math.Pow(C, 2)));
            double trapezio = ((A + B) * C) / 2.0;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }

        public static void Esfera()
        {
            /* 1011
             Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
            A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

            Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), 
            assumem que o resultado da divisão entre dois inteiros é outro inteiro.
             */

            double R, volume, pi = 3.14159;

            Console.WriteLine("Digite o valor de (R) raio:");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4 / 3.0) * (pi * Math.Pow(R, 3));

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }

        public static void Salario_bonus()
        {
            /*1009
             Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas 
            por ele no mês (em dinheiro). Sabendo que este vendedor ganha 15% de comissão sobre suas vendas 
            efetuadas, informar o total a receber no final do mês, com duas casas decimais.
             */
            string nome_vend;
            double salar_fixo, total_vend;

            Console.WriteLine("Nome do Vendedor:");
            nome_vend = Console.ReadLine();

            Console.WriteLine("Digite o Salário fixo:");
            salar_fixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Total de vendas realizadas:");
            total_vend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = total_vend * 0.15 + salar_fixo;

            Console.WriteLine("Vendedor: " + nome_vend);
            Console.WriteLine("Salario sem bonus: "+salar_fixo);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Total Salário com Bonus 15%: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Salario()
        {
            int num = int.Parse(Console.ReadLine());
            int hora_trab = int.Parse(Console.ReadLine());
            double valor_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valor_hora * hora_trab;

            Console.WriteLine("NUMBER = " + num);
            Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
        }

        public static void Media()
        {
            double A, B, media;

            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }

        public static void CalcAreaCir()
        {
            /*A fórmula para calcular a área de uma circunferência é: area = π . raio2. Considerando para este problema que π = 3.14159: 
              - Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.
             */
            double raio, area, n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (n * (Math.Pow(raio, 2)));

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

        public static void CalcRetan()
        {

            double larg, compri, valor_metro, area, preco;
            Console.WriteLine("Digite a largura do terreno:");
            larg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o comprimento do terreno:");
            compri = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor do metro(M²):");
            valor_metro = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            area = larg * compri;

            preco = area * valor_metro;

            Console.WriteLine("AREA(M²):" + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO($):" + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }

        public static void Registro()
        {

            Console.WriteLine("Entre com seu nome completo:");
            String nome_completo = Console.ReadLine();

            Console.WriteLine("Quanto quarto tem na sua casa ?");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite valores: (Nome / idade / altura)");
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome_completo);
            Console.WriteLine(n1);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Estruturawhile
    {
        public static void CresDecres()
        {

            int X, Y;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            X = int.Parse(vet[0], CultureInfo.InvariantCulture);
            Y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0], CultureInfo.InvariantCulture);
                Y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            }
           
        }

        public static void EstruIdade()
        {
            int cont;
            double media, idade, somaidade;

            Console.WriteLine("Digite a idade:");
            idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cont = 0;
            somaidade = 0.0;

            if(idade < 0)
            {
                Console.WriteLine("Impossivel Calcular");
            }
            else
            {
                while (idade >= 0)
                {
                        somaidade += idade;
                        cont++;
                        idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                media = somaidade / cont;
                Console.WriteLine(media.ToString("F2"), CultureInfo.InvariantCulture);
            }
        }

        public static void SenhaFixa()
        {
            int senha = 2002, senhadigi;

            Console.WriteLine("Digite a senha para acesso:");
            senhadigi = int.Parse(Console.ReadLine());
            while (senha != senhadigi)
            {
                Console.WriteLine("Senha Inválida");
                senhadigi = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido");
            Console.ReadLine();
        }

        public static void Quadrante()
        {
            int x, y;
            string[] vet;

            Console.WriteLine("Digite o numero do Plano Cartesiano: X Y");
            vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0], CultureInfo.InvariantCulture);
            y = int.Parse(vet[1], CultureInfo.InvariantCulture);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante Primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Quandrante Segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante Terceiro");
                }
               else if(x > 0 && y < 0)
                {
                    Console.WriteLine("Quandrante Quarto");
                }
                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0], CultureInfo.InvariantCulture);
                y = int.Parse(vet[1], CultureInfo.InvariantCulture);
            }
        }

        public static void ValidaNota()
        {
            Console.WriteLine("Digite a Nota da Avaliação:");
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while(n1 < 0.0 || n1 > 10.00)
            {
                Console.WriteLine("Nota Invalida");
                n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while(n2 < 0.0 || n2 > 10.0)
            {
                Console.WriteLine("Nota Invalida");
                n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double media = (n1 + n2) / 2.0;
            Console.WriteLine("Media: "+media.ToString("F2"), CultureInfo.InvariantCulture);
        }

        public static void TipoCombus()
        {
            int combustivel, contalcool = 0, contgaso = 0, contdies = 0;

            Console.WriteLine("Digite o codigo do combustivel: 1-Alcool / 2-Gasolina / 3-Diesel / 4-Sair");
            combustivel = int.Parse(Console.ReadLine());

            while(combustivel != 4)
            {
                if (combustivel == 1)
                {
                    contalcool++;
                }
                else if(combustivel == 2)
                {
                    contgaso++;
                }
                else if(combustivel == 3)
                {
                    contdies++;
                }
                else if( combustivel > 4)
                {
                    Console.WriteLine("Codigo incorreto");
                }
                combustivel = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + contalcool);
            Console.WriteLine("Gasolina: " + contgaso);
            Console.WriteLine("Diese: " + contdies);
        }

        public static void Idademedia()
        {
            int somaidade = 0;
            double cont = 0.0;

            Console.WriteLine("Digite as idades para ter a media das idades inseridas:");
            int idade = int.Parse(Console.ReadLine());

            while(idade >= 0)
            {
                cont++;
                somaidade += idade;
                idade = int.Parse(Console.ReadLine());
            }
            double media = somaidade / (double)cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}