using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor
{
    class Program
    {

        // Executor which gets as parameter double[], double and returns the function invoke 
        //  From main call this executor with lambda and write an expression which returns the sum of all 
        //      elements which are bigger than the second parameter

        static double[] arr = { 1, 2, 5, 1001239, -7.4568, 1231.5345, 2.22222, 3.14 };
        static double min = 6.7;
        static double ExecutorOnArrayDouble(Func<double[], double, double> f)
        {
            double result = f(arr, min);
            return result;
        }

        static void Main(string[] args)
        {
            ExecutorOnArrayDouble((rra, min) =>
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
