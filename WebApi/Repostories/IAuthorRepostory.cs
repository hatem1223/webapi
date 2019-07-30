using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Repostories
{
    public interface IAuthorRepostory
    {
        IEnumerable<Author> GetAuthors();

        Author GetAuthorByid(int Authorid);

        void DeleteAuthor(int Authorid);

        void InsertAuthor(Author author);

        void UpdateAuthor(Author author);

        void Save();


    }
}
