using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1.OOPs
{

    internal class Student
    {
        int studid;
        string name;
        int percent;
        Batch batch1 = new Batch();
        Address1 addr = new Address1();

        public Student()
        {

        }
        public Student(int studid, string name, int percent, Batch batch1, Address1 addr)
        {
            this.Studid = studid;
            this.Name = name;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Addr = addr;

        }

        public int Studid { get => studid; set => studid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        internal Batch Batch1 { get => batch1; set => batch1 = value; }
        internal Address1 Addr { get => addr; set => addr = value; }
    }
        class Batch
        {
            string batchname;
            string subject;

        
        public Batch()
        {

        }
        public Batch(string batchname, string subject)
        {
            this.Batchname = batchname;
            this.subject = subject;
        }
       
        public string Batchname { get => Batchname; set => Batchname = value; }
        public string Subject { get => Subject; set => Subject = value; }
    }
    class Address1
    {
        string street;
        string city;

        public Address1()
        {

        }
        public Address1(string street, string city)
        {
            this.street = street;
            this.city = city;
        }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
    }

    class StudTest
    {
        static void Main(string[] args)
        {
            Student s1=new Student();
            s1.Studid = 101;
            s1.Name = "pooja";
            s1.Percent = 77;
            s1.Batch1.Batchname = "Microsoft";
            s1.Batch1.Subject = "c#";
            s1.Addr.Street = "vidhyanagar road";
            s1. Addr.City = "karad";

            Console.WriteLine(s1.Studid);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Percent);
            Console.WriteLine(s1.Batch1.Batchname);
            Console.WriteLine(s1.Batch1.Subject);
            Console.WriteLine(s1.Addr.Street);
            Console.WriteLine(s1.Addr.City);
        
        }
    }
    class Emp
    {
        int empid;
        string name;
        int salary;
        Dept department = new Dept();

        public Emp()
        {

        }

        
        
        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public Dept Department { get => department; set => department = value; }
    }
    class Dept
    {
        int deptid;
        string deptname;

        public Dept()
        {

        }

        public string Deptid { get => Deptid; set => Deptid = value; }
        public string Deptname { get => deptname; set => deptname = value; }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e1=new Emp();
            e1.Empid = 15;
            e1.Name = "pooja";
            e1.Salary = 30000;
            e1.Department.Deptid =
            e1.Department.Deptname = "ABCDE";

            Console.WriteLine(e1.Empid);
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.Salary);
            Console.WriteLine(e1.Department.Deptid);
            Console.WriteLine(e1.Department.Deptname);

            
        }
    }

    class flat
    {
        int flatno;
        string flatname;
        owner o1 = new owner();

        public flat()
        {


        }
        public int Flatno { get => Flatno; set => Flatno = value; }
        public string Flatname { get => flatname; set => flatname = value; }
        internal owner owner { get => owner; set => owner = value; }
    }
    class owner
    {
        string name;
        string addr;
        int age;
        string profession;
        char gender;

        public owner()
        {


        }
        public string   Name { get => name; set => name = value; }
        public string Address { get => addr; set => addr = value; } 
        public int Age { get => age; set => age = value; }  
        public string Profession { get => profession; set => profession = value; }
        public char Gender { get => gender; set => gender = value; }    
    }
    class flatside
    {
        static void Main(string[] args)
        {
            flat f1=new flat();
            f1.Flatno = 7;
            f1.Flatname = "ABCDE";
            
            
        }
    }

    class order
    {
        int orderid;
        string orderdate;
        customer c = new customer();
        Item mm = new Item();

        public order()
        {

        }
        public int Orderid { get => orderid; set => orderid = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Item Mm { get => mm; set => mm = value; }
        internal customer C { get => c; set => c = value; }
    }
    class customer
    {
        int custid;
        string custname;
        long custmobileno;

        public customer()
        {


        }
        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        public long Custmobileno { get => custmobileno; set => custmobileno = value; }


    }
    class Item
    {
        string itemname;
        int itemcostprice;
        int itemsellingprice;
        int itemid;
        string itemdelivarydate;

        public Item()
        {
            
        }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Itemcostprice { get => itemcostprice; set => itemcostprice = value; }
        public int Itemsellingprice { get => itemsellingprice; set => itemsellingprice = value; }   
        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemdelivarydate {get => itemdelivarydate; set => itemdelivarydate = value; }

    }
    class orderrrrrrrrr
    {
        static void Main(string[] args)
        {
            order o1=new order();
            o1.Orderid = 12345;
            o1.Orderdate = "23 march";
            o1.C.Custid = 3245;
            o1.C.Custname = "ABCDE";
            o1.C.Custmobileno = 9876546789;
            o1.Mm.Itemname = "XYZAD";
            o1.Mm.Itemcostprice = 250;
            o1.Mm.Itemsellingprice = 220;
            o1.Mm.Itemid = 87654;
            o1.Mm.Itemdelivarydate = "7 April";

             Console.WriteLine(o1.Orderid);
            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.C.Custid);
            Console.WriteLine(o1.C.Custname);
            Console.WriteLine(o1.C.Custmobileno);
            Console.WriteLine(o1.Mm.Itemname);
            Console.WriteLine(o1.Mm.Itemcostprice);
            Console.WriteLine(o1.Mm.Itemsellingprice);
            Console.WriteLine(o1.Mm.Itemid);
            Console.WriteLine(o1.Mm.Itemdelivarydate);

        }
    }
}

