using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    class Program
    {
        static void Executor(Action<int, int> f, int num1, int num2)
        {
            f(num1,num2);
        }
        static double Executor(Func<double, double, double> f, double num1, double num2)
        {
            return f(num1, num2);
        }

        static void ExecutorOnArrayInt(Action<int[]> f)
        {
            int[] arr = { 1, 2, 5, 10, 100, 1000 };
            f(arr);
        }

        static double[] arr = { 1, 2, 5, 1001239, -7.4568, 1231.5345, 2.22222, 3.14 };
        static double min = 6.7;
        static double ExecutorOnArrayDouble(Func<double[], double, double> f)
        {
            double result = f(arr, min);
            return result;
        }

        // use action or function
        // Executor which gets as parameter int, int and invoked the function
        //  From main call this executor with lambda and write an expression which prints their sum 
        // Executor which gets as parameter double and return the result of function invoke
        //  From main call this executor with lambda and write an expression which return their mul
        // Executor which gets as parameter int[] and invoke the function 
        //  From main call this executor with lambda and write an expression which sets all values to zero (void)
        // Executor which gets as parameter double[], double and returns the function invoke 
        //  From main call this executor with lambda and write an expression which returns the sum of all 
        //      elements which are bigger than the second parameter

        static void Main(string[] args)
        {

            Executor((num1, num2) => Console.WriteLine($"{num1} + {num1} = {num1 + num1}"), 10, 20);

            Console.WriteLine(Executor((num1, num2) => num1 * num1, 10, 20));

            ExecutorOnArrayInt(arr =>
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = 0;
                }
            });

            ExecutorOnArrayDouble((rra, nim) =>
            {
                double sum = 0.0;
                foreach (var item in rra)
                {
                    sum = sum + (item > min ? item : 0.0);
                }
                return sum;
            });
        }

    }
}
