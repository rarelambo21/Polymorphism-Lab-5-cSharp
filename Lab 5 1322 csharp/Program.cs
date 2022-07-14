using System;
using System.Collections.Generic;

namespace Lab_5_1322_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            string title, author;
            int isbn;

            Item[] items = new Item[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter B for Book or P for Periodical");
                c = char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (c == 'B')
                {
                    Console.WriteLine("Please enter the name of the Book");
                    title = Console.ReadLine();
                    Console.WriteLine("Please enter the author of the Book");
                    author = Console.ReadLine();
                    Console.WriteLine("Please enter the ISBN of the Book");
                    isbn = Convert.ToInt32(Console.ReadLine());

                    items[i] = new Book(title, author, isbn);

                    title = "";
                    author = "";
                    isbn = -1;
                }
                else if (c == 'P')
                {
                    Console.WriteLine("Please enter the name of Periodical");
                    title = Console.ReadLine();
                    Console.WriteLine("Please enter the ISBN of the Book");
                    isbn = Convert.ToInt32(Console.ReadLine());

                    items[i] = new Periodical(title, isbn);

                    title = "";
                    isbn = -1;

                }


            }
                Console.WriteLine(" ");
                Console.WriteLine("Your Items: ");
                foreach(Item item in items)
                {
                    item.getListing();
                }
        }
    }
}
