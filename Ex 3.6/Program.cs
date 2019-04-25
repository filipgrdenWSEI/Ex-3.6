using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] tab =
            {
                new int[] {1,2},
                new int[] {3, 4, 5, 6 },
                new int[] {7, 8, 9}
            };

            int sum = 0;
            for(int i = 0; i < tab.Length; ++i)
            {
                for(int j = 0; j < tab[i].Length; ++j)
                {
                    sum += tab[i][j];
                }
            }

            Console.WriteLine(sum);
            Console.ReadKey();

        }
    }
}
