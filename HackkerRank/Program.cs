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

        static long aVeryBigSum(long[] arr)
        {
            long total = 0;
            for(int i=0;i<arr.Length; ++i)
            {
                total += arr[i];
            }
            return total;
        }
    }
}
