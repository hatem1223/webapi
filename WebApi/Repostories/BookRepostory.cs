using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Context;
using WebApi.Models;

namespace WebApi.Repostories
{
    public class BookRepostory : IBookRepostory
    {
        private readonly ApiContext apiContext;
        public BookRepostory(ApiContext _apiContext)
        {
            apiContext = _apiContext;
        }
        public void DeleteBook(int BookId)
        {
            Book book = apiContext.Books.Find(BookId);
            apiContext.Books.Remove(book);
        }

        public Book GetBookbyid(int BookId)
        {
            return apiContext.Books.Find(BookId);
        }

        public IEnumerable<Book> GetBooks()
        {
            return this.apiContext.Books.ToList();
        }

        public void InsertBook(Book book)
        {
            this.apiContext.Books.Add(book);
        }

        public void Save()
        {
            apiContext.SaveChanges();
        }
        
        public void UpdateBook(Book book)
        {
            apiContext.Entry(book).State = EntityState.Modified; 
        }

    }
}
