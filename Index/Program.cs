using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[] arr = { 9, 4, 6, 7, 3, 2, 5, 1 };
            int calc = Calculate(n, arr);
            Console.WriteLine(calc);
        }
        public static int Calculate (int n, int[] arr)
        {
            int moves = 0;
           for(int i = 1; i< n; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    moves += arr[i - 1] - arr[i];
                    arr[i] = arr[i - 1];
                }
            }
            return moves;
        }
    }
}
