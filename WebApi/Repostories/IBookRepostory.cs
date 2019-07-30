using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repostories
{
   public interface IBookRepostory
    {
        IEnumerable<Book> GetBooks();
        Book GetBookbyid(int BookId);
        void DeleteBook(int BookId);

        void InsertBook(Book book);

        void UpdateBook(Book book);
        void Save();
    }
}
