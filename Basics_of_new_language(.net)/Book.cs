﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics_of_new_language_dot_net_
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {

        }
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

        }
    }
}
