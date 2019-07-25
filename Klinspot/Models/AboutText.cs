using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Klinspot.Models
{
    public class AboutText
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [Column(TypeName ="ntext")]
        public string Text { get; set; }

        [MaxLength(100)]
        public string Photo { get; set; }
    }
}