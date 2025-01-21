using Books.Domain;
using Microsoft.EntityFrameworkCore;

namespace Books.Infrastructure;

public class BooksDbContext:DbContext
{
    public BooksDbContext(DbContextOptions options):base(options)
    {
        
    }
    //the name of the table created
    public DbSet<Book> Books { get; set; }
}