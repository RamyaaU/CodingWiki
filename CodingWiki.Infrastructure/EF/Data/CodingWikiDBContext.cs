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

        //protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}
    }
}
