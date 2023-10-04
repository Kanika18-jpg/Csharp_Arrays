using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    internal class Mu
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of columns: ");
            int c = int.Parse(Console.ReadLine());

            int[,] a = new int[r, c];

            for(int i=0;i < r; i++)
            {
                for(int j=0;j < c; j++)
                {
                    a[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for(int i=0;i < r; i++)
            {
                for(int j=0;j < c; j++)
                {
                    Console.Write(a[i,j] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
