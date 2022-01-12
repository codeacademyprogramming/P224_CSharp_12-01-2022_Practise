using P224Example.Enums;
using P224Example.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P224Example.Interface
{
    interface ILibraryManager
    {
        public List<Book> Books { get;}

        public void ADD(string name,string authorName,int pageCount,Genre genre);
        public Book ShowInfo(string name);
        public List<Book> Search(string str);
        public List<Book> Filter(string str);

    }
}
