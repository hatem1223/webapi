using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Author
    {
        public int AuthorId { set; get; }

        public String AuthorName { set; get; }

        public List<Book> books { set; get; }
    }
}
