using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMath
{
    class ManualСalculations
    {
        private static int Multiply(int factor, int multiplicand)
        {
            if(factor == 1)
            {
                return multiplicand;
            }
            List<int> num = new List<int>();
            int resultat = multiplicand;

            while(true)
            {
                if(factor % 2 == 0)
                {
                    factor = factor / 2;
                    resultat = resultat * 2;
                }
                else
                {
                    num.Add(resultat);
                    factor--;
                }
                if(factor == 1)
                {
                    break;
                }
            }
            return resultat + num.Sum();
        }

        private static int NOD(int m, int n)
        {
            int nod = 0;
            for (int i = 1; i <= (n * m); i++)
            {
                if (m % i == 0 && n % i == 0)
                {
                    nod = i;
                }
            }
            return nod;
        }

        private static int NOK(int a, int b)
        {
            int nok = 0;
            for (int i = 1; i <= (a * b); i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    nok = i;
                    break;
                }
            }
            return nok;
        }

        private static double Division(double dividend, double divider)
        {
            double[] arrayNumDiv = dividend.ToString().Select(f => double.Parse(f.ToString())).ToArray();

            string temp = null;
            string result = null;

            for (int i = 0; i < arrayNumDiv.Length; i++)
            {
                int temp2 = 0;
                temp += arrayNumDiv[i].ToString();
                double.TryParse(temp, out double num);

                if (num < divider)
                    continue;

                else if (num > divider)
                {
                    while (true)
                    {
                        if (num % divider == 0)
                        {
                            result += num / divider;

                            if (temp2 != 0)
                                temp = temp2.ToString();
                            else if (i != arrayNumDiv.Length - 1)
                                result += "0";

                            if (temp2 == 0 && i < arrayNumDiv.Length - 1)
                            {
                                temp = null;
                            }

                            if (i == arrayNumDiv.Length - 1)
                            {
                                if (temp2 != 0)
                                {
                                    double d = temp2 / divider;
                                    result += d.ToString().Substring(1);
                                    return double.Parse(result);
                                }
                                else
                                    return double.Parse(result);
                            }
                            break;
                        }
                        else
                        {
                            temp2++;
                            temp = temp2.ToString();
                            num--;
                        }
                    }
                }
            }
            return dividend / divider;
        }
    }
}
