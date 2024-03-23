using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mission11_McLaughlin.Models
{
    public class BookContext: DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
