using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConsoleApp1UI
{
    class Chapter : Book //Inheritance.
    {
        //This inherits the propeties form the Book class. 

        public string ChapterName { get; set; }

        public Chapter(string chapName, string title, string author, int pages )
        {
            this.ChapterName = chapName;
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
        }
        public override void SayHello1(string name)
        {
            Console.WriteLine($"Hello ya losser! {name}!");
        }
    }
}
