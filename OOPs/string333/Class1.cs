using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.string333
{
    internal class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter  element");
            string? s = Console.ReadLine();


            for (int i = 0; i < s.Length; i++)
            {

                s = s.ToUpper();
                Console.WriteLine(s[i]);
            }
            for (int j = s.Length - 1; j >= 0; j--)
            {
                s = s.ToLower();
                Console.WriteLine(s[j]);
            }








        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            string ss = "mohen mehta";
            //string dd=ss.Replace('m','R')
            ss = ss.Replace('m', 'R');
            Console.WriteLine(ss);
            // Console.WriteLine(dd);

        }
    }
    class Class3
    {
        static void Main(string[] args)
        {
            //
            string s2 = "red apple red ball red rose";
            //s2 = s2.Replace("red", "blue");
            string d2 = s2.Replace("red", "blue");
            //Console.WriteLine(s2);
            Console.WriteLine(d2);
        }
    }
    class Class4
    {
        static void Main(string[] args)
        {
            //split function
            string s = "I work in prorigo";
            string[] arr = s.Split(" ");

            foreach (string word in arr)
            {
                char firstchar = word[0];
                string half = word.Substring(1);
                firstchar = char.ToUpper(firstchar);
                Console.WriteLine(firstchar + half + " ");
            }
            foreach (string word in arr)
             {
                 for (int i = word.Length - 1; i >= 0; i--)
                 {
                     Console.WriteLine(word[i]);
                 }
                 Console.Write(" ");

             }
           /* for (int i = 0; i < arr.Length; i++)
            {
                string word = arr[i];
                for (int j = word.Length - 1; j >= 0; j--)
                {
                    Console.WriteLine(word[j]);
                }
                Console.Write(" ");
            }*/
        }

    }
    class Class5
    {
        static void Main(string[] args)
        {

            bool ispalindrome = true;
             string  s = "thinkquotient";
            int end = s.Length - 1;
            for (int start = 0; start < end; start++, end--)
            {
                if (s[start] != s[end])
                {
                    ispalindrome = false;
                    Console.WriteLine("string is not palindrome" + false);
                    break;
                }

            }
            if (ispalindrome == true)
            {
                Console.WriteLine("string is palindrome=" + true);
            }
                Console.WriteLine();
            
        }
    }



        
    
}

