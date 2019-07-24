using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klinspot.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required,MaxLength(300)]
        public string Title { get; set; }

        [Required, MaxLength(300)]
        public string Slug { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }
    }
}