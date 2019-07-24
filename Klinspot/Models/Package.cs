using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klinspot.Models
{
    public class Package
    {
        public int Id { get; set; }

        [Required]
        public int OrderBy { get; set; }

        [Required,MaxLength(50)]
        public string Title { get; set; }

        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        [Required,MaxLength(1000)]
        public string Options { get; set; }
    }
}