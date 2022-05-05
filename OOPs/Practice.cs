using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOPs
{
    internal class Practice
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            al.RemoveRange(2, 4);
            al.RemoveAt(2);
            al.RemoveAt(3);
            al.RemoveAt(3);

            foreach (var i in al)
                Console.WriteLine(i);

        }
    }
    /* class KLPO
     {
         static void Main(string[] args)
         {
             Console.WriteLine("Enter mobile number");
             long mb = long.Parse(Console.ReadLine());
             int c = 0;
             while(mb>0)
             {
                 c++;
                 mb=mb/10;
             }
             if(c==10)
                 Console.WriteLine("valid mobile number");
             else
                 Console.WriteLine("Invalid mobile number");
         }


     }*/
    class MKIU
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Tue");
            al.Add("Wed");
            al.Add("Thu");
            al.Add("Fri");
            al.Add("Sat");

            al.Reverse();
            foreach (var i in al)
                Console.WriteLine(i);
        }
    }

    class LOPI
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string s= Console.ReadLine();
            string[]sp=s.Split(' ');
            for(int i=0;i<sp.Length;i++)
            {
                int result = sum;
                char[]ch=sp[i].ToCharArray();
                for(int j=0;j<ch.Length;j++)
                {
                    if(ch[j] >='A' && ch[j]<'Z')
                    {
                        int a = ch[j] -64;

                        sum = sum + a;

                    }
                }
                Console.WriteLine(sp[i]+"="+sum);

            }
        }
    }
}








