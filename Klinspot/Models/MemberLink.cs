using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Klinspot.Models
{
    public class MemberLink
    {
        public int Id { get; set; }

        [Required]
        public int MemberId { get; set; }

        [Required,MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Url { get; set; }

        public Member Member { get; set; }
    }
}