using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDeterminant
{
    class MatrixDeterminant
    {
        private static double GetDeterminant(double[,] initialMatrix)
        {
            double[,] matrix = initialMatrix.Clone() as double[,];
            int n = matrix.GetLength(1);
            int permutations = 0;
            double epsilon = 1e-9;

            for (int i = 0; i < n - 1; i++)
            {
                if (Math.Abs(matrix[i, i]) < epsilon)
                {
                    int k = 1;

                    while (i + k < n && Math.Abs(matrix[i + k, i]) < epsilon)
                    {
                        k++;
                    }

                    if (i + k < n)
                    {
                        double temp;

                        for (int j = 0; j < n; j++)
                        {
                            temp = matrix[i, j];
                            matrix[i, j] = matrix[i + k, j];
                            matrix[i + k, j] = temp;
                        }

                        permutations++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = i + 1; k < n; k++)
                {
                    double factor = matrix[k, i] / matrix[i, i];

                    for (int j = 0; j < n; j++)
                    {
                        matrix[k, j] -= matrix[i, j] * factor;
                    }
                }
            }

            double determinant = Math.Pow(-1, permutations);

            for (int i = 0; i < n; i++)
            {
                determinant *= matrix[i, i];
            }

            return determinant;
        }

        static void Main(string[] args)
        {
            double[,] matrix =
            {
                {25, 21, 22, 20, 29},
                {45, 78, 89, 23, 11},
                {12, 13, 14, 15, 19},
                {10, 17, 15, 13, 16},
                {15, 19, 14, 17, 12}
            };

            int n = matrix.GetLength(1);

            Console.WriteLine("Задана матрица:");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            double determinant = GetDeterminant(matrix);

            Console.WriteLine("Определитель матрицы = " + determinant);

            Console.ReadKey();
        }
    }
}
