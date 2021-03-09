using HackkerRank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackkerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = solveMeFirst(5, 6);
            Console.WriteLine(result);

            int[] arr = { 1, 2, 3, 4, 10, 11 };
            int result2 = simpleArraySum(arr);
            Console.WriteLine(result2);

            long[] arr2 = { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            long result3 = aVeryBigSum(arr2);
            Console.WriteLine(result3);

            int[] arr3 = { 1,2,3,-1,-2,-3,0,0};
            plusMinus(arr3);
        }

        /// <summary>
        /// solveMeFirst
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int solveMeFirst(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// simpleArraySum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int simpleArraySum(int[] arr)
        {
            int total = 0;
            for(int i=0;i<arr.Length;++i)
            {
                total += arr[i];
            }
            return total;
        }

        /// <summary>
        /// aVeryBigSum
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static long aVeryBigSum(long[] arr)
        {
            long total = 0;
            for(int i=0;i<arr.Length; ++i)
            {
                total += arr[i];
            }
            return total;
        }

        /// <summary>
        /// https://www.hackerrank.com/challenges/plus-minus/problem
        /// </summary>
        /// <param name="arr"></param>
        static void plusMinus(int[] arr)
        {
            double pos = 0;
            double neg = 0;
            double zero = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] > 0)
                {
                    ++pos;
                }
                else if (arr[i] < 0)
                {
                    ++neg;
                }
                else if (arr[i] == 0)
                {
                    ++zero;
                }
            }

            Console.WriteLine(pos / arr.Length);
            Console.WriteLine(neg / arr.Length);
            Console.WriteLine(zero / arr.Length);
        }
    }
}
