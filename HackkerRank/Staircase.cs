using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackkerRank
{
    class Staircase
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/staircase/problem
        /// </summary>
        /// <param name="n"></param>
        public static void stairCase(int n)
        {
            string message = String.Empty;
            for(int i=1;i<=n;++i)
            {
                Console.WriteLine("{0,"+n+"}", message += "#");
            }
        }
    }
}