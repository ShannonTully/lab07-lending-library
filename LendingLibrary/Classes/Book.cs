using System;
using System.Collections.Generic;
using System.Text;

namespace LendingLibrary.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author Writer { get; set; }

        public enum Genres
        {
            Fiction,
            NonFiction,
            Fantasy,
            Historical,
            HowTo,
            SciFi,
            TextBook
        }
    }
}
