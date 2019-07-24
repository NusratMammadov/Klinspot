using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [MaxLength(100)]
        public string  Photo { get; set; }

        public Category Category { get; set; }
    }
}