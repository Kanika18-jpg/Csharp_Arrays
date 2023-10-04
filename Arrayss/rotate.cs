using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class rotate
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
           

            for(int k=0; k<3; k++)
            {
                int last = a[a.Length -1];
            for(int j= a.Length-1; j>0; j--)
            {
                    a[j] = a[j - 1];  
            }
                a[0] = last;

            }
            for(int i=0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();

        }
    }
}
