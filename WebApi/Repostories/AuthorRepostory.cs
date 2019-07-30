using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Context;
using WebApi.Models;

namespace WebApi.Repostories
{
    public class AuthorRepostory : IAuthorRepostory
    {
        private readonly ApiContext apiContext;
        public AuthorRepostory(ApiContext _apiContext)
        {
            apiContext = _apiContext;
        }
        public void DeleteAuthor(int Authorid)
        {
            Author author = apiContext.Authors.Find(Authorid);
            apiContext.Authors.Remove(author);
           
        }

        public Author GetAuthorByid(int Authorid)
        {
            return apiContext.Authors.Find(Authorid);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return apiContext.Authors.ToList();
        }

        public void InsertAuthor(Author author)
        {
            apiContext.Authors.Add(author);
        }

        public void Save()
        {
            apiContext.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            apiContext.Entry(author).State = EntityState.Modified;
        }
    }
}
