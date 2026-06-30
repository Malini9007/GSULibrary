using Microsoft.EntityFrameworkCore;

namespace GSULibrary.Models
{
    public class GSUBookContext : DbContext
    {
        public GSUBookContext(DbContextOptions<GSUBookContext> options)
            : base(options)
        {
        }

        public DbSet<GSUBook> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GSUBook>().HasData(

                new GSUBook
                {
                    GSUBookId = 1,
                    Name = "Clean Code",
                    Author = "Robert C. Martin",
                    ISBN = "978-0132350884",
                    Price = 35.99M,
                    NumberOfCopy = 3
                },

                new GSUBook
                {
                    GSUBookId = 2,
                    Name = "Design Patterns",
                    Author = "Gang of Four",
                    ISBN = "978-0201633610",
                    Price = 54.99M,
                    NumberOfCopy = 1
                },

                new GSUBook
                {
                    GSUBookId = 3,
                    Name = "The Pragmatic Programmer",
                    Author = "David Thomas",
                    ISBN = "978-0135957059",
                    Price = 49.99M,
                    NumberOfCopy = 2
                }

            );
        }
    }
}