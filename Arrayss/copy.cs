using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class copy
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[a.Length];

            for(int i=0; i<a.Length; i++)
            {
                b[i] = a[i];
            }
            Console.WriteLine("The copied array :");
            for(int  j=0; j<b.Length; j++)
            {
                Console.Write(b[j] + " ");
            }
            Console.ReadLine();
        }
    }
}
