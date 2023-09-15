using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Infrastructure.EF.Models
{
    [Table("SubCategory")]
    public class SubCategory
    {
        [Key]
        public int SubCategory_Id { get; set; }

        public string Name { get; set;  }
    }
}
