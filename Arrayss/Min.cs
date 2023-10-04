using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Min
    {
        static void ArrMin(int[] arr)
        {
            int a = arr[0];

            for(int i = 1; i < 5; i++)
            {
                if (arr[i] < a)
                {
                    Console.WriteLine("The minimum element : " + arr[i]);
                }
        
            }
        }     
        
        public static void Main(string[] args)
        {
            int[] arr = {10,20,39,5,12};
          ArrMin(arr);
                Console.ReadLine();
        }
    }
}
