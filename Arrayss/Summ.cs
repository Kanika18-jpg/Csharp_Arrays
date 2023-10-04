using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Summ
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int sum = 0;

            for(int i=0; i<a.Length; i++)
            {
                sum += a[i];
            } 
            Console.WriteLine("The sum of all the elements: " +sum);
            Console.ReadLine();
        }
    }
}
