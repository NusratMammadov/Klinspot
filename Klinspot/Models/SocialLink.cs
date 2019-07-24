using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class SocialLink
    {
        public int Id { get; set; }

        [Required]
        public int OrderBy { get; set; }

        [Required,MaxLength(50)]
        public string Icon { get; set; }

        [Required, MaxLength(100)]
        public string Url { get; set; }
    }
}