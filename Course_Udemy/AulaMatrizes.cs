using System;
using System.Globalization;

namespace ExercMatrizes
{
    class AulaMatrizes
    {
	    public static void Matrizes()
	    {
            int number = int.Parse(Console.ReadLine());
            int[,] mat = new int[number, number];

            for (int i = 0; i < number; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < number; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            };

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(mat[i, i] + " | ");
            }
            int count = 0;
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative Numbers: " + count);

            Console.ReadLine();
        }

        public static void PositionMatriz()
        {
            string[] vetor = Console.ReadLine().Split(" ");
            int M = int.Parse(vetor[0]);
            int N = int.Parse(vetor[1]);

            int[,] mat = new int[M, N];

            for(int i = 0; i < M; i++)
            {
                string[] X = Console.ReadLine().Split(' ');
                for(int j = 0;j < N; j++)
                {
                    mat[i, j] = int.Parse(X[j]);
                }
            }

            int value = int.Parse(Console.ReadLine());

            for(int i = 0;i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    if(value == mat[i, j])
                    {
                        Console.WriteLine("Position "+ i +","+ j + ":");
                        if(j > 0)
                        {
                            Console.WriteLine("Left: "+mat[i, j - 1]);
                        }
                        if(i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j < N - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if(j > 0)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }

                }
            }
        }
    }
}
