using Microsoft.EntityFrameworkCore;
using SM.Demo.Domain.Entities;
using System;

namespace SM.Demo.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Author>().HasData(
                new Author { Id = Guid.NewGuid(), Name = "First Author", DOB = new DateTime(1999, 1, 19), Email = "Email@Email.com" }
                );
            builder.Entity<Author>().HasData(
                new Author { Id = Guid.NewGuid(), Name = "Second Author", DOB = new DateTime(1956, 12, 1), Email = "Email@Email.com" }
                );
            builder.Entity<Author>().HasData(
                new Author { Id = Guid.NewGuid(), Name = "Third Author", DOB = new DateTime(1980, 6, 4), Email = "Email@Email.com" }
                );


        }
    }
}
