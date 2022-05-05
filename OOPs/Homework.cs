using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Teacher
    {
        int teacherid;
        string teachername;
        long mobileno;

        public Teacher( int id ,string name,long number)
        {
            teacherid = id;
            teachername = name;
            mobileno = number;
        }
        public Teacher()
        {


        }
        static void Main(string[] args)
        {
            Teacher T1 = new Teacher(1234, "ABCDE", 9856745693);
        }

        
    }
}
