using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class Admin
    {
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Fullname { get; set; }

        [Required, MaxLength(50)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }
    }
}