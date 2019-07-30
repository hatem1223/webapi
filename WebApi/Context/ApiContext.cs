using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Context
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions options)
            :base(options)
        {
                
        }

        public DbSet<Book> Books { set; get; }
        public DbSet<Author> Authors { set; get; }
    }
}
