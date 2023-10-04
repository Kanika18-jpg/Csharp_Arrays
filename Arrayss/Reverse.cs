using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Reverse
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                int a = int.Parse(Console.ReadLine());
                arr[i] = a;
            }
            Console.WriteLine("Reversed Array:");
            for(int i=arr.Length-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
    }
}
