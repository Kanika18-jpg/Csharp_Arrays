using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class intersection
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 18, 27, 3, 4, 5 };

            Console.WriteLine("The intersection :");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.Write(a[i] + " ");
                    }
                }
            }
            Console.ReadLine();

        }
    }
}
