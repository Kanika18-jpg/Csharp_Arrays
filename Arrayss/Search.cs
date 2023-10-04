using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Search
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };

            Console.WriteLine("Enter the element you want to search: ");

            int b = int.Parse(Console.ReadLine());
           


            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b)
                {
                    Console.WriteLine("The index of the searched item : " + i);
             
                }
                if(i== -1)
                {
                    Console.WriteLine("Element not found in the array.");
                 
                }
            }
            Console.ReadLine();
        }
    }
}
