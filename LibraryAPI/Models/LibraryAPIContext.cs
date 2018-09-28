using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LibraryAPI.Models
{
    public class LibraryAPIContext : DbContext
    {
        public LibraryAPIContext(DbContextOptions<LibraryAPIContext> options) : base(options) {}
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}