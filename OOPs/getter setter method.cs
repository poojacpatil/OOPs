using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class mobile
    {
        string mobilename;
        int price;

        public mobile()
        {
            Console.WriteLine("Mobile created");
            mobilename = "Iphone";
            price = 90000;
        }
        static void Main(string[] args)
        {
            mobile m1 = new mobile();
            mobile m2 = new mobile();
        }

    }


    class pen
    {
        string penbrand;
        string pencolor;
        int penprice;
        //constructer
        public pen(string brand,string color,int price )
        {

            penbrand = brand;
            pencolor = color;
            penprice = price;
        }
        public pen()
        {
            
        }
        static void Main(string[] args)
        {
            pen p1 = new pen("cello", "black", 20);
            
        }
        //setter getter method
        //main 2 object creation
        public void Setpenbrand(string brand)
        {
            penbrand = brand;
        }
        public string getpenbrand()
        {
            return penbrand;
        }
        public void Setpencolor(string color)
        {
            pencolor = color;
        }
        public string getpencolor()
        {
            return pencolor;
        }
        public void Setpenprice(int price)
        {
            penprice = price;
        }
        public int getpenprice()
        {
            return penprice;
        }

    }
    class pentest
    {
        static void Main(string[] args)
        {
            pen p1 = new pen();
            p1.Setpenbrand("cello");
            p1.Setpencolor("pink");
            p1.Setpenprice(10);


            Console.WriteLine(p1.getpenbrand());
            Console.WriteLine(p1.getpencolor());
            Console.WriteLine(p1.getpenprice());
        
       
                pen p2 = new pen();
                Console.WriteLine("Enter penbrand");
                string pb = Console.ReadLine();
                p2.Setpenbrand(pb);
                Console.WriteLine("Enter pencolor ");
                string pc = Console.ReadLine();
                p2.Setpencolor(pc);
                Console.WriteLine("Enter penprice");
                int pp = Convert.ToInt32(Console.ReadLine());
                p2.Setpenprice(pp);

                Console.WriteLine(p2.getpenbrand());
                Console.WriteLine(p2.getpencolor());
            Console.WriteLine(p2.getpenprice());
       }

            
    }


        class stock
        {
            float openingprice;
            float closingprice;
            string stockname;
        //constructor
        public stock()
        {
            Console.WriteLine("stock created");
            openingprice = 7654.76f;
            closingprice = 98765.65f;
            stockname = "abcde";
        }
        static void Main(string[] args)
        {
            stock s1=new stock();
            stock s2=new stock();
        }
        // getter setter method
        //main 2 object creation
            public void Setopeningprice(float price)
            {
                openingprice = price;
            }
            public float getopeningprice()
            {
                return openingprice;
            }
            public void Setclosingprice(float price)
            {
                closingprice = price;
            }
            public float getclosingprice()
            {
                return closingprice;
            }
            public void Setstockname(string name)
            {
                stockname = name;
            }
            public string getstockname()
            {
                return stockname;
            }

        }

        class validstock
        {
            static void Main(string[] args)
            {
                stock s1 = new stock();
                s1.Setopeningprice(123.56f);
                s1.Setclosingprice(567.7f);
                s1.Setstockname("ABCDE");

                Console.WriteLine(s1.getopeningprice());
                Console.WriteLine(s1.getclosingprice());
                Console.WriteLine(s1.getstockname());

    
               stock s2 = new stock();
                Console.WriteLine("Enter openingprice");
                int op = Convert.ToInt32(Console.ReadLine());
                s2.Setopeningprice(op);
               Console.WriteLine("Enter closingprice");
               int cp = Convert.ToInt32(Console.ReadLine());
               s2.Setclosingprice(cp);
                 Console.WriteLine("Enter stockname");
                 string nm = Console.ReadLine();
                s2.Setstockname(nm);

               Console.WriteLine(s2.getopeningprice());
               Console.WriteLine(s2.getclosingprice());
               Console.WriteLine(s2.getstockname());
            }
        }
    class country
    {
        string countryname;
        int noofstates;
        string capital;

        public string Countryname
        {
            get { return countryname; }
            set { countryname = value; }
        }
        public int State
        {
            get { return noofstates; }
            set { noofstates = value; }
        }
     
        public string Capital
        {
            get { return capital; }
            set { capital = value; }    
        }
        static void Main(string[] args)
        {
           country c1=new country();
            c1.Countryname = "India";
            c1.noofstates = 28;
            c1.capital = "Delhi";

            Console.WriteLine( c1.countryname);
            Console.WriteLine(c1.noofstates);
            Console.WriteLine(c1.capital);
        }
    }
     
}   
     
    
    




       
    
    

