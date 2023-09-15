using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki.Infrastructure.EF.Models
{
    [Table("Publisher")]
    public class Publishers
    {
        [Key]
        public int Publisher_Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Location { get; set; }
    }
}
