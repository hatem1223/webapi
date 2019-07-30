using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Book
    {
        public int Bookid { set; get; }

        public String BookTitle { set; get; }

        public String BookCategory { set; get; }

        public int AuthorKey { set; get; }

        [ForeignKey("AuthorKey")]
        public Author author { set; get; }

        
    }
}
