using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class unique
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 2, 3, 4, 4, 5 };
            int[] b = new int[a.Length];
            int j = 0,p=0;

            for(int i=0; i<a.Length-1; i++)
            {
                if (a[i] != a[i + 1])
                {
                    b[j++] = a[i];
                    p++;
                }
            }
            b[p] = a[a.Length - 1];

            for (int i = 0; i < p; i++)
            {
                
                a[i] = b[i];

            }

            for (int k=0; k<p; k++)
            {
                Console.WriteLine(a[k]);
            }
            
            Console.ReadLine();
        }
    }
}
