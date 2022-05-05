using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class JadgedArray
    {
        static void Main(string[] args)
        {
            int[][] a = new int[3][];
            a[0] = new int[5];
            a[1]= new int[2];  
            a[2]= new int[3];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a[i].GetLength(1); j++)
                {
                 a[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
