using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class BookRepository
    {

    public List<BookModel> GetAllBooks()
        {
            return DataSource();

        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.id == id).FirstOrDefault();

        }
        public List<BookModel> SearchBook(string BookName, string Author)
        {
            return DataSource().Where(x => x.BookName.Contains(BookName) && x.Author.Contains(Author)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()    
            {

            new BookModel() { id = 1, BookName = "MVC", Author = "nity" },
            new BookModel() { id = 2, BookName = "MVCq", Author = "nit" },
            new BookModel() { id = 3, BookName = "ok", Author = "basit" },
            new BookModel() { id = 4, BookName = "MVC", Author = "nitydd" },
            new BookModel() { id = 5, BookName = "MVeC", Author = "nityff" },
            };
        }
    }
}
