using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class SumOfTwo
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int sum = 9;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] + a[j] == sum)
                    {
                        Console.WriteLine(a[i] + "and" + a[j]);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}