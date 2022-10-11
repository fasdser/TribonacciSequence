using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] tr = new double[] { 1, 1, 1 };
            Console.WriteLine(Tribonacci(tr, 10));
            Console.ReadKey();
        }


        public static double[] Tribonacci(double[] signature, int n)
        {
            if (n == 0)
            {
                return new double[] { };
            }

            double a = signature[0];
            double b = signature[1];
            double c = signature[2];
            double[] array = new double[n];
            if (n < 3)
            {
                Array.Copy(signature, array, n);
                return array;
            }

            array[0] = signature[0];
            array[1] = signature[1];
            array[2] = signature[2];
            for (int i = 3; i < n; i++)
            {
                double temp = a;
                a = b;
                b = c;
                c = temp + a + b;
                array[i] = c;
            }


            return array;
        }

        public static double[] Tribonacci1(double[] s, int n)
        {
            double[] res = new double[n];
            Array.Copy(s, res, Math.Min(3, n));

            for (int i = 3; i < n; i++)
                res[i] = res[i - 3] + res[i - 2] + res[i - 1];

            return n == 0 ? new double[] { 0 } : res;
        }

        public static double[] Tribonacci2(double[] signature, int n)
        {
            if (n == 0)
                return new double[] { 0.0 };

            double[] answer = new double[n];

            if (n < 3)
            {
                Array.Copy(signature, answer, n);
                return answer;
            }

            Array.Copy(signature, answer, 3);

            for (int i = 3; i < answer.Length; i++)
            {
                answer[i] = answer[i - 1] + answer[i - 2] + answer[i - 3];
            }

            return answer;
        }
    }
}
