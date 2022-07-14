using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_1322_csharp
{
    public class Item
    {
        private string title;


        public Item()
        {
            title = "";
        }

        public Item(string inTitle)
        {
            title = inTitle;
        }

        protected string getTitle()
        {
            return title;
        }

        protected void setTitle(string inTitle)
        {
            title = inTitle;
        }

        virtual public void getListing()
        {
            Console.Write(title);
        }

    }
}
