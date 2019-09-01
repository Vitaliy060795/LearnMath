using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;

namespace LearnMath
{
    class VectorAlgebra
    {
        private static Vector VectorAdditionAndSubtraction(Vector vector1, Vector vector2, char i)
        {
            Vector vectorResult = new Vector();
            switch(i)
            {
                case '-':
                    vectorResult = vector1 - vector2;
                    break;
                case '+':
                    vectorResult = vector1 + vector2;
                    break;
                default:
                    break;
            }

            return vectorResult;
        }

        private static bool EqualsVector(Vector vector1, Vector vector2)
        {
            if (vector1.Equals(vector2))
                return true;
            return false;
        }

        private static double  ModuleVector(Vector vector1)
        {
          double a = Math.Pow(vector1.X, 2);
          double b = Math.Pow(vector1.Y, 2);
          return Math.Sqrt(a + b);
        }

        private static double ScalarProductVectors(Vector vector1,Vector vector2)
        {
            return (vector1.X * vector2.X) + (vector1.Y * vector2.Y);
        }

        private static Vector MultiplicationVectorNumber(Vector vector1, int factor)
        {
            Vector res = new Vector();
            res.X = vector1.X * factor;
            res.Y = vector1.Y * factor;
            return res;
        }

        private static double VectorProduct(Vector vector1, Vector vector2)
        {
            return Vector.CrossProduct(vector1, vector2);
        }

        private static Vector3 Vector3Product(Vector3 vector1, Vector3 vector2)
        {
            return Vector3.Cross(vector1, vector2);
        }

        private static double VectorProjection(Vector vector1, Vector vector2)
        {
            return ScalarProductVectors(vector1, vector2) / ModuleVector(vector2);
        }

        private static double AngleBetweenVectors(Vector vector1, Vector vector2)
        {
            return ScalarProductVectors(vector1, vector2) / (ModuleVector(vector2) * ModuleVector(vector1));
        }
    }
}
