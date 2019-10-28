using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class Book
    {
        public int AddBookId { get; set; }
        public string AddBookName { get; set; }
        public string AddBookIsbn { get; set; }
        public string AddBookAuthor { get; set; }
        public Book(string bookName,string bookIsbn,string bookAuthor)
        {
            AddBookName = bookName;
            AddBookAuthor = bookAuthor;
            if (bookIsbn.Length == 13)
            {
                AddBookIsbn = bookIsbn;
            }
            else
            {
                AddBookIsbn = "false";
            }
        }
    }
}