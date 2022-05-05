using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Book
    {
        public int price, Id;
        public string name, author;

        static void Main(string[] args)
        {
            Book p1 = new Book();
            p1.price = 250;
            p1.Id = 111;
            p1.name = "A passage to india";
            p1.author = "E.M.Foster";

            Book p2 = new Book();
            Console.WriteLine("Enter the price,Id,name,author");
            p2.price = Convert.ToInt32(Console.ReadLine());
            p2.Id = Convert.ToInt32(Console.ReadLine());
            p2.name = Console.ReadLine();
            p2.author = Console.ReadLine();


            Book p3 = new Book();
            Console.WriteLine("Enter the price,Id,name,author");
            p3.price = Convert.ToInt32(Console.ReadLine());
            p3.Id = Convert.ToInt32(Console.ReadLine());
            p3.name = Console.ReadLine();
            p3.author = Console.ReadLine();


            Console.WriteLine($"Book name:{p1.name} Author{p1.author} price{p1.price} Id{p1.Id}");
            Console.WriteLine($"Bookname:{p2.name}   Author {p2.author} price={p2.price}  Id{p2.Id}");
            Console.WriteLine($"Bookname:{p3.name} Author{p3.author} price{p3.price} Id{p3.Id}");
        }
    }

    class Calci
    {
        public void Add(int a, int b)
        {

        }
    }


    class voter
    {
        long adharcard;
        string votername;
        string votecasted;

        public void SetAdharCard(long card)
        {
            adharcard = card;

        }
        public long getAdharCard()
        {
            return adharcard;
        }

    }


    class Movie
    {
        string moviename;
        string MovieDirector;
        string MovieProducer;
        int rating;

        public void setMovieName(string name)
        {
            moviename = name;
        }
        public string getMovieName()
        {
            return moviename;
        }
        public void setMovieDirector(string director)
        {
            MovieDirector = director;
        }
        public string getMovieDirector()
        {
            return MovieDirector;
        }
        public void setMovieProducer(string producer)
        {
            MovieProducer = producer;
        }
        public string getMovieProducer()
        {
            return MovieProducer;
        }
        public void setRating(int Rate)
        {
            rating = Rate;
        }
        public int getRating()
        {
            return rating;
        }
    }

    class TestMovie
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.setMovieName("Yellow");
            m1.setMovieDirector("ABCDE");
            m1.setMovieProducer("XYZAB");
            m1.setRating(101);


            Console.WriteLine(m1.getMovieName());
            Console.WriteLine(m1.getMovieDirector());
            Console.WriteLine(m1.getMovieProducer());
            Console.WriteLine(m1.getRating());
        

            Movie m2 = new Movie();
            Console.WriteLine("Enter Movie Name");
            string mn = Console.ReadLine();
            m2.setMovieName(mn);
            Console.WriteLine("Enter Movie director");
            string md = Console.ReadLine();
            m2.setMovieDirector(md);
            Console.WriteLine("Enter Moive producer");
            string mp = Console.ReadLine();
            m2.setMovieProducer(mp);
            Console.WriteLine("Enter rating");
            int r = Convert.ToInt32(Console.ReadLine());
            m2.setRating(r);

            Console.WriteLine(m2.getMovieName());
            Console.WriteLine(m2.getMovieDirector());
            Console.WriteLine(m2.getMovieProducer());
            Console.WriteLine(m2.getRating());
        }

    }

}







        
      
    
  




        
    
 
        
    

