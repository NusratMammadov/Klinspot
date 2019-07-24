using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class AboutText
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(100)]
        public string PhotoLarge { get; set; }

        [MaxLength(100)]
        public string PhotoRightTop { get; set; }

        [MaxLength(100)]
        public string PhotoRightBottom { get; set; }
    }
}