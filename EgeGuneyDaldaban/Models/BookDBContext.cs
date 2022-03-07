using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EgeGuneyDaldaban.Models;

namespace EgeGuneyDaldaban.Models
{
    public class BookDBContext:DbContext
    {
        public BookDBContext(DbContextOptions<BookDBContext> options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }
        public DbSet<EgeGuneyDaldaban.Models.User> User { get; set; }
    }
}
