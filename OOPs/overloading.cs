using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class overloading
    {
        
         static int result;
        public static  void Add(int a, int b)
        {
            result = a + b;
        }
        public static void Add(float a,float b)
        {
            float d = a + b;
            Console.WriteLine(d);

        }
        static void Main(string[] args)
        {
            overloading.Add(5, 6);
            overloading.Add(7, 5);
        }
    }
}
