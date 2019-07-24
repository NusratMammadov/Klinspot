using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klinspot.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Slug { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        public bool IsPromo { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [MaxLength(100)]
        public string Pdf { get; set; }

        [MaxLength(100)]
        public string Doc { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }
    }
}