using Klinspot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klinspot.ViewModels
{
    public class ContactPage
    {
        public PageHeader PageHeader { get; set; }

        public Setting Setting { get; set; }

        public List<SocialLink> SocialLinks { get; set; }
    }
}