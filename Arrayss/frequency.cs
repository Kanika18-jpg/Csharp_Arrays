using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class frequency
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 1, 1, 1, 1, 1, 1 };
            int f = 0;

            for(int i=1; i<a.Length; i++)
            {
                if (a[0] == a[i])
                {
                    f++;
                }
            }
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
