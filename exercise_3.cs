using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {

        static void RunOnArray(Action<int> f, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                f(arr[i]);
            }
        }

        static int CountOnArray(Func<int, bool> f, int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (f(arr[i]))
                {
                    counter++;
                }
            }
            return counter;
        }

        static bool IFGreaterThan100(int x)
        {
            return x > 100;
        }

        static void Main(string[] args)
        {
            int[] arr = { 12312, 33333, 51000, 7, 10, 100 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            RunOnArray(x => Console.WriteLine(x), arr);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i] * 2);
            //}
            RunOnArray(x => Console.WriteLine(x * 2), arr);

            //int count100 = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 100)
            //    {
            //        count100++;
            //    }
            //}
            int count100 = CountOnArray(x => x > 100, arr);
            Console.WriteLine(CountOnArray(x => x > 100, arr));
            int count100_agan = CountOnArray(IFGreaterThan100, arr); // better?

            //int count0 = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == 0)
            //    {
            //        count0++;
            //    }
            //}
            int count0 = CountOnArray(x => x == 0, arr);
        }
    }
}


