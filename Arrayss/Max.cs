using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Max
    {
        public static void Main(string[] args)
        {
            int[] a = { 22, 23, 44, 52, 14, 82, 35, 28, 27 };
            int max = a[0];

            for(int i=0;  i<a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
