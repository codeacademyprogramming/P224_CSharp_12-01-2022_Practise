using P224Example.Enums;
using P224Example.Exceptions;
using P224Example.Interface;
using P224Example.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Services
{
    class LibraryManager : ILibraryManager
    {
        public List<Book> Books => _books;
        private List<Book> _books;
        public LibraryManager()
        {
            _books = new List<Book>();
        }

        public void ADD(string name, string authorName, int pageCount, Genre genre)
        {
            if (_books.Exists(x=>x.Name.ToUpper()==name.ToUpper()))
            {
                throw new SameBookalreadyAddedException("Bu kitab Artiq var");
            }

            Book book = new Book(name, authorName, pageCount, genre);

            _books.Add(book);
        }

        public List<Book> Filter(string str)
        {
            return _books.FindAll(x => x.AuthorName == str || x.Genre.ToString() == str);
        }

        public List<Book> Search(string str)
        {
            return _books.FindAll(n => n.Name == str || n.AuthorName == str || n.Genre.ToString() == str || n.PageCount.ToString() == str);
        }

        public Book ShowInfo(string name)
        {
            Book book = _books.Find(n => n.Name.ToLower() == name.ToLower());
            if ( book==null )
            {
                throw new BookNotFoundException("Kitab tapilmadi"); 
            }
            return book;
        }
    }
}
