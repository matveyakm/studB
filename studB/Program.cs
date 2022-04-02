using System;

namespace studB
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double max = 0;
            int CifMax = 0;
            for (int A = 1; A <= 5000; A++)
            {
                for (int C = A+1; C <= 5000; C++)
                {
                    double B = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(A, 2));
                    if ( B == Math.Round(B) && B >= A)
                    {
                        count++;
                        if ((A + B + C) > max)
                        {
                            max = A + B + C;
                            CifMax = C;
                        }
                    }
                }

            }
            Console.WriteLine(count + "    " + CifMax);
        }
    }
}
