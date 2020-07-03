using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1UI
{
    class Book
    {
        //Attributes descrie what the class is.

        public static int BooksWriten = 0;//using static attributes
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        //Make this dude private so no one can change it!
        private string _rating;// Getters and Setters!
        public string Rating
        {
            get
            {
                return _rating;
            }
            set
            {// value is what is entered it. This checks and make sure the rating is one of these. 
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR" )
                {
                    _rating = value;
                }
                else
                {
                    _rating = "NR";
                }
            }
        }

        /******************Constructor****************/

        public Book() //Defualt book. No arguments.
        {

        }
        public Book(string title, string author, int pages, string rating)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Rating = rating;
            BooksWriten++;
        }

        /***************Object Methods******************/ //Class Method 1
        public bool BookHonors()
        {
            if (Pages >= 1000)
            {
                return true;
            }
            return false;
        }
        public int GetBookCount()
        {
            return BooksWriten;
        }
        /*****************Static Method**************/
        public static void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
        public virtual void SayHello1(string name)
        {
            Console.WriteLine($"Hello {name}!");
        }
    }
}
