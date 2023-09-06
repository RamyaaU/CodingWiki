using CodingWiki.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Infrastructure.EF.Data
{
    public class CodingWikiDBContext : DbContext
    {
        public CodingWikiDBContext()
        {

        }

        public CodingWikiDBContext(DbContextOptions<CodingWikiDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);


            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Suits", ISBN = "123B120", Price = 10.99m },
                new Book { BookId = 2, Title = "Never Have I Ever", ISBN = "12123B120", Price = 11.99m }
                );

            var bookList = new Book[]
            {
                new Book{  BookId = 3, Title = "Vampire Diaries", ISBN = "10123B120", Price = 17.99m },
                new Book{  BookId = 4, Title = "Red Hoodie", ISBN = "10188B170", Price = 87.99m },
                new Book{  BookId = 5, Title = "Hilda", ISBN = "10180AB170", Price = 47.99m },
            };

            modelBuilder.Entity<Book>().HasData(bookList);
        }
    }
}
