using P224Example.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Models
{
    class Book
    {
        public Book(string name,string authorName,int pageCount, Genre genre)
        {
            Name = name;
            AuthorName = authorName;
            Genre = genre;
            PageCount = pageCount;
        }
        public string Name;
        public string AuthorName;
        public int PageCount;
        public Genre Genre;

        public override string ToString()
        {
            return $"Name:{Name}\n" +
                $" Author:{AuthorName}\n" +
                $"  Genre:{Genre}\n" +
                $"PageCount:{PageCount}";

        }

    }
}
