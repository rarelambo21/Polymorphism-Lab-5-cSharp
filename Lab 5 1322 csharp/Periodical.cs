using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_1322_csharp
{
    public class Periodical : Item
    {
        private int isbn;

        public Periodical() : base()
        {
            isbn = -1;
        }

        public Periodical(string inTitle, int inIsbn) : base(inTitle)
        {
            isbn = inIsbn;
        }

        public override void getListing()
        {
            Console.Write("Periodical Title - ");
            base.getListing();
            Console.Write("\n");
            Console.WriteLine("ISBN - " + getIsbn());
            Console.WriteLine(" ");
        }

        public int getIsbn()
        {
            return isbn;
        }

        public void setIsbn(int inIsbn)
        {
            isbn = inIsbn;
        }
    }
}