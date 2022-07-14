using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_1322_csharp
{
    public class Book : Item
    {
        private string author;
        private int isbn;

        public Book() : base()
        {
            author = "";
            isbn = -1;
        }

        public Book(string inTitle, string inAuthor, int inIsbn) : base(inTitle)
        {
            author = inAuthor;
            isbn = inIsbn;
        }

        public override void getListing()
        {
            Console.Write("Book Name - ");
            base.getListing();
            Console.Write("\n");
            Console.WriteLine("Author - " + getAuthor());
            Console.WriteLine("ISBN - " + getIsbn());
            Console.WriteLine(" ");
        }

        public string getAuthor()
        {
            return author;
        }

        public int getIsbn()
        {
            return isbn;
        }

        public void setAuthor(string inString)
        {
            author = inString;
        }

        public void setIsbn(int inIsbn)
        {
            isbn = inIsbn;
        }

    }
}