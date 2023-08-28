using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Infrastructure.EF.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public int Title { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
    }
}
