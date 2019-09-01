using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    class MatrixAgebra
    {
        private static int[,] MatrixMultiplicationByNumber(int[,] mas, int numMultiply)
        {
            int[,] matrix = new int[mas.GetLength(0), mas.GetLength(1)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    matrix[i, j] = mas[i, j] * numMultiply;
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            return matrix;
        }

        private static int[,] MatrixMultiplication(int[,] mas, int[,] mas2)
        {
            if (mas.GetLength(1) != mas2.GetLength(0))
                throw new Exception("Matrices cannot be multiplied");

            int[,] matrix = new int[mas.GetLength(0), mas2.GetLength(1)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    matrix[i, j] = mas[i, j] * mas2[i, j];
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            return matrix;
        }

        private static int[,] MatrixAddition(int[,] mas, int[,] mas2)
        {
            if (mas.GetLength(1) != mas2.GetLength(0))
                throw new Exception("Matrices cannot be multiplied");

            int[,] matrix = new int[mas.GetLength(0), mas2.GetLength(1)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    matrix[i, j] = mas[i, j] + mas2[i, j];
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            return matrix;
        }

        private static double[,] Transpose(double[,] mas)
        {
            double[,] matrix = new double[mas.GetLength(0), mas.GetLength(1)];
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    matrix[j, i] = mas[j, i];
                }
                Console.WriteLine();
            }
           return matrix;
        }

        public static double DeterminantRec(double[,] matrix)
        {
            if (matrix.Length == 4)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            double sign = 1, result = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                double[,] minor = GetMinor(matrix, i);
                result += sign * matrix[0, i] * DeterminantRec(minor);
                sign = -sign;
            }
            return result;
        }

        private static double[,] GetMinor(double[,] matrix, int n)
        {
            double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(0) - 1];
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 0, col = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == n)
                        continue;
                    result[i - 1, col] = matrix[i, j];
                    col++;
                }
            }
            return result;
        }

        private static double[,] FindIngnverseMatrix(double[,] mas)
        {
            double determinant = DeterminantRec(mas);
            double[,] matrix = new double[mas.GetLength(0), mas.GetLength(1)];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    matrix[i, j] = mas[i, j] / determinant;
                    Console.Write(matrix[j, i]);
                }
                Console.WriteLine();
            }
            return matrix;
        }

        private static double[,] FindingAnAlliedMatrix(double[,] mas)
        {
            double determinant = DeterminantRec(mas);
            double[,] matrix = Transpose(mas);

            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    matrix[i, j] = mas[i, j] / determinant;
                }
                Console.WriteLine();
            }
            return matrix;
        }

        private static double Rank(double[,] matrix)
        {
            int rang = 0;
            int q = 1;

            while (q <= matrix.GetLength(0) && q <= matrix.GetLength(1))
            {
                double[,] matbv = new double[q, q];
                for (int i = 0; i < (matrix.GetLength(0) - (q - 1)); i++)
                {
                    for (int j = 0; j < (matrix.GetLength(1) - (q - 1)); j++)
                    {
                        for (int k = 0; k < q; k++)
                        {
                            for (int c = 0; c < q; c++)
                            {
                                matbv[k, c] = matrix[i + k, j + c];
                            }
                        }

                        if (DeterminantRec(matbv) != 0)
                        {

                            rang = q;
                        }
                    }
                }
                q++;
            }

            return rang;
        }
    }
}

