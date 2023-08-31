using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterativos
{
    internal class Program
    {
        // Iterative method to calculate the factorial of a number
        static long IterativeFactorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Iterative method to calculate the sum of natural numbers up to n
        static int IterativeNaturalSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        // Iterative method to calculate the n-th Fibonacci number
        static int IterativeFibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            int a = 0, b = 1, result = 0;
            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int number = 5;
            int n = 10;

            // Calculate factorial iteratively
            long iterativeFactorial = IterativeFactorial(number);
            Console.WriteLine($"Factorial of {number} (Iterative): {iterativeFactorial}");

            // Calculate the sum of natural numbers iteratively up to n
            int iterativeSum = IterativeNaturalSum(n);
            Console.WriteLine($"Sum of naturals up to {n} (Iterative): {iterativeSum}");

            // Calculate the n-th Fibonacci number iteratively
            int iterativeFibonacci = IterativeFibonacci(n);
            Console.WriteLine($"Fibonacci({n}) (Iterative): {iterativeFibonacci}");
        }
    }
}
