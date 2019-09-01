using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    class SLAU_gauss_Method
    {
        public static double[] SLAU_gauss(double[,] matrix, double[] rightPart)
        {
            double s = 0;
            double[,] Matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            
            double[] res = new double[matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               SLAU_kramer_Method.equal(Matrix, matrix);
                SLAU_kramer_Method.change(i, Matrix, rightPart);
            }

            for (int k = 0; k < matrix.GetLength(0) - 1; k++)
            {
                for (int i = k + 1; i < matrix.GetLength(0); i++)
                {
                    for (int j = k + 1; j < matrix.GetLength(0); j++)
                    {
                        Matrix[i, j] = Matrix[i, j] - Matrix[k, j] * (Matrix[i, k] / Matrix[k, k]);
                    }
                    rightPart[i] = rightPart[i] - rightPart[k] * Matrix[i, k] / Matrix[k, k];
                }
            }
            for (int k = matrix.GetLength(0) - 1; k >= 0; k--)
            {
                s = 0;
                for (int j = k + 1; j < matrix.GetLength(0); j++)
                    s = s + Matrix[k, j] * res[j];
                res[k] = (rightPart[k] - s) / Matrix[k, k];
            }
            return res;
        }
    }
}