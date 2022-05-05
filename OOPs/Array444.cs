using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Array444
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];


            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter {i}th element in array");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine();
            }
        }
    }

    class Add
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 22, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            //c={1,2,3,4,5,6,7,8,9,10}
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
    /*
     for (int i = 0; i <= c.Length - 1; i++)
     {
         if (i < a.Length)
         {
             c[i] = a[i];
             Console.WriteLine(c[i]);
         }
         else
         {
             c[i] = b[i - a.Length];
             Console.WriteLine(c[i]);
         }
     }


*/
    class AB
    {
        //print alternate number
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            //{1,6,2,7,3,8,4,9,5,10}
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
                c[k] = b[i];
                k++;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }


        }
    }


    class ABC
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = { 5, 6, 7, 8, 9, 10 };
            //{1,5,2,6,3,7,4,8,9,10}
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for (int i = 0; i > c.Length;)
            {
                if (k < a.Length && k < b.Length)
                {
                    c[i] = a[k];
                    i++;
                    c[i] = b[k];
                    i++;
                }
                else if (k < a.Length)
                {
                    c[i] = a[k];
                    i++;
                }
                else

                {
                    c[i] = b[k];
                    i++;
                }
                k++;
            }

            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i] + " ");
            }


        }
    }
    class program
    {

        static void Main(string[] args)
        {/*
        //WAP to add elements to single dimensional int array and print element from 1D array
        
            int[] a = new int[5];
              a[0]=Convert.ToInt32(Console.ReadLine());
              a[1] = Convert.ToInt32(Console.ReadLine());
              a[2] = Convert.ToInt32(Console.ReadLine());
              a[3] = Convert.ToInt32(Console.ReadLine());
              a[4] = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]+" ");
            }
        }*/
            Console.WriteLine("Enter the length of array=");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[length];


            for (int i = 0; i < length; i++)
            {

                Console.Write(a[i] + " ");

            }
        }

    }
    class sum
    {
        static void Main(string[] args)
        {
            //WAP to accept dimension of 1D array and creat and accept data in the array.calculate the average value of array element
            int[] a = new int[5];
            a[0] = Convert.ToInt32(Console.ReadLine());
            a[1] = Convert.ToInt32(Console.ReadLine());
            a[2] = Convert.ToInt32(Console.ReadLine());
            a[3] = Convert.ToInt32(Console.ReadLine());
            a[4] = Convert.ToInt32(Console.ReadLine());
            int sum = 0, avg;



            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            avg = sum / a.Length;
            Console.WriteLine("The average of numbers=" + avg);
            /*
           Console.WriteLine("Enter the length of array");
           int Length = Convert.ToInt32(Console.ReadLine());
           int[] a = new int[Length];
            int sum = 0, avg;
           for (int i = 0; i <a. Length; i++)
           {
               sum +=a[i];
           }
           avg = sum / a.Length;
           Console.WriteLine("The average of numbers=" + avg);*/
        }

    }

    class Element
    {
        static void Main(string[] args)
        {
            //WAP the program copy an array by iterating the array
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = new int[5];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + " ");
            }
            Console.WriteLine("\n\n");
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = a[i];

                Console.WriteLine(b[i] + " ");
            }

        }
    }

    class Index
    {
        static void Main(string[] args)
        {
            //WAP to search for a given number in array and according print the index it self
            int[] a = { 3, 4, 2, 6, 8 };
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                {
                    Console.WriteLine("index of given number is" + i);
                    break;
                }
            }
        }
    }
    class XYZ
    {
        //WAP to find the maximum and minimum value in the array
        static void Main(string[] args)
        {
            int[] a = { 1200, 56, 78, -3, 90, 876, 76, 23 };
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
                else if (min > a[i])
                {
                    min = a[i];
                }
            }
            Console.WriteLine("max=" + max);
            Console.WriteLine("min=" + min);
        }
    }

    class Even
    {
        //WAP to print all negative element in an array and also count total number of negative element in an array
        static void Main(string[] args)
        {
            int[] arr = { 11, 23, 4, -5, 6, -8, -2, 90, 23 };
            int p = 0, n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    p++;
                else
                    n++;
            }
            int[] positive = new int[p];
            int[] negative = new int[n];

            p = 0;
            n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    positive[p] = arr[i];
                    p++;
                }
                else if (arr[i] < 0)
                {
                    negative[n] = arr[i];
                    n++;
                }
                Console.WriteLine("print negative element in an array=" + (n));
            }
        }
    }

    class Insertinarray
    {
        //WAP to insert an element in a specific position into an array
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Console.WriteLine("how many elements u want to insert initially");
            int size = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the position or index where u want to insert");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the data u want to insert");
            int data = Convert.ToInt32(Console.ReadLine());

            if (pos == size)
            {
                arr[size] = data;
            }
            else if (pos >= 0 && pos < size)
            {
                for (int k = size - 1; k >= pos; k--)
                {
                    arr[k + 1] = arr[k];
                }
                arr[pos] = data;
            }
            else
                Console.WriteLine("Index out of range");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }

    class pair
    /*To find unique pair of intergers in array whose sum is given number
     given array=[2,4,3,5,6,-2,4,7,8,9]
    given sum=7 interger number,
    whose sum is equal to valueP:7 (2,5) (4,3) (-2,9)
    */

    {
        static void Main(string[] args)
        {
            int[] a = { 2, 4, 3, 5, 6, -2, 4, 7, 8, 9 };
            int sum = 7;

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == sum)
                        Console.WriteLine($"pair that gives sum=7 is {a[i]}+{a[j]}");
                }
            }
        }
    }

    class count
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int even = 0, odd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Enter {i}th element in array");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                    even++;
                else
                    odd++;

            }
            Console.WriteLine("Even elements of array is" + even);
            Console.WriteLine("odd elements of array is" + odd);

        }
    }


    class HBNJ
    {
        static public int frqy(string s ,char ch)
        {
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]==ch)
                    c++;
            }
            return c;

            static void Main(string[] args)
            {
                string s = "amita";
                string search = "mitta";
                bool isfound = true;
                foreach (char c in search)
                {
                    int ori=frqy(s,c);
                    int sea=frqy(search,c);
                    if (ori < sea)
                    {
                        isfound= false;
                        break;
                    }
                }
                if(isfound)
                    Console.WriteLine("string can be formed");
                else
                    Console.WriteLine("Not");
            }

        }
    }
    class DE
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5,6,7,8,9,10};
            int[] arr = { 1, 5, 7, 3, 8, 9, 10 };
            int sum = 0;
            int restSum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                 sum=sum+arr[i];    

                for (int j = 1; j < arr.Length; j++)
                {
                    restSum = restSum -sum;
                }
              
            }
        }
    }

    class HGFD
    {
        //sum of array 1+2+3+4+5=15
        static void Main(string[] args)
        {
            int[] a = new int[5];
           a[0]=Convert.ToInt32(Console.ReadLine());  
            a[1]=Convert.ToInt32(Console.ReadLine());  
            a[2]=Convert.ToInt32(Console.ReadLine());
            a[3]=Convert.ToInt32(Console.ReadLine());
            a[4]=Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for(int i=0;i<a.Length;i++)
            {
                sum+=a[i];
            }
            Console.WriteLine("sum="+sum);
        }
    }
}
 
    




            
              

    

