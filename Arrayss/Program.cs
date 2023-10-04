using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of n");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Elements:");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        
    }
}
