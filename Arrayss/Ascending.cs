using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Ascending
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 45, 3, 2, 55, 6, 43 };

            Array.Sort(a);

            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
