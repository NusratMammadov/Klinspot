using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Setting
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string Logo { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [MaxLength(50)]
        public string HeaderPhone { get; set; }

        [MaxLength(50)]
        public string ContactPhone { get; set; }

        public float Lat { get; set; }

        public float Lng { get; set; }

        [MaxLength(100)]
        public string VideoUrl { get; set; }
    }
}