using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Project> Projects { get; set; }
    }
}