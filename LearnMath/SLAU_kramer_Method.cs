using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    class SLAU_kramer_Method
    {
       private static double[] SLAU_kramer(double[,] matrix, double[] rightPart)
        {
            double[,] Matrix = new double[matrix.GetLength(0), matrix.GetLength(1)];
            double[] res = new double[matrix.GetLength(0)];
            double det1 = MatrixAgebra.DeterminantRec(matrix);
            if (det1 == 0) return null;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                equal(Matrix, matrix);
                change(i, Matrix, rightPart);
                res[i] = MatrixAgebra.DeterminantRec(Matrix) / det1;
            }
            return res;

        }
       public static void change( int N, double[,] matrix, double[] b)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                matrix[i, N] = b[i];
        }

        public static void equal( double[,] matrix, double[,] B)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(0); j++)
                    matrix[i, j] = B[i, j];
        }

    }
}
            
