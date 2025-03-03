using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_C__
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book()
        {
            Console.WriteLine("Default Constructor");
        }
        public Book(string title, string author) : this()
        {
            this.Title = title;
            this.Author = author;
            Console.WriteLine("Title: " + title+ "Author: " + author);
        }
        public Book(string title, string author, string isbn) : this()
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            Console.WriteLine("Title: " + title+ "Author: " + author+ "ISBN: " +isbn);
        }
    }
}
