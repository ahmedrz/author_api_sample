using Microsoft.EntityFrameworkCore;
using System;

namespace ProductAPI.DAL
{
    public class AuthorsDbContext : DbContext
    {
        public AuthorsDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=ProductsDb;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, Name = "Author 1", Country = "Iraq", BOD = DateTime.Now.AddYears(-40) },
                new Author { Id = 2, Name = "Author 2", Country = "United States", BOD = DateTime.Now.AddYears(-50) }
                );

            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Author 1 : Book 1", AuthorId = 1, Description = "Book 1 description", IssueDate = DateTime.Now.AddDays(-1) },
                new Book { Id = 2, Name = "Author 1 : Book 2", AuthorId = 1, Description = "Book 2 description", IssueDate = DateTime.Now.AddDays(-1) },
                new Book { Id = 3, Name = "Author 2 : Book 1", AuthorId = 2, Description = "Book 1 description", IssueDate = DateTime.Now.AddDays(-1) },
                new Book { Id = 4, Name = "Author 2 : Book 2", AuthorId = 2, Description = "Book 2 description", IssueDate = DateTime.Now.AddDays(-1) }
                );

        }
    }
}
