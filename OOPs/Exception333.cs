using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Exception333
    {
        static string s="null";
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            try
            {
                int a=int. Parse(Console.ReadLine());
                int b=int. Parse(Console.ReadLine());
                Console.WriteLine("divide="+a/b);
                Console.WriteLine(s);

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("divide by zero");
            }
            catch(NullReferenceException ee)
            {
                Console.WriteLine("null exception occours");
            }
           
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
            
        }
    }
    class RTYU
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your mobile number");
            long a=long.Parse(Console.ReadLine());
            
        }
    }
}
