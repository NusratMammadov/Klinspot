using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Klinspot.Models;

namespace Klinspot.ViewModels
{
    public class Homepage
    {
        public List<Slide> Slides { get; set; }

        public List<Service> Promos { get; set; }

        public AboutText AboutText { get; set; }

        public List<Service> Services { get; set; }

        public List<Member> Members { get; set; }

        public List<Category> Categories { get; set; }

        public List<Project> Projects { get; set; }

        public List<Package> Packages { get; set; }

        public List<Client> Clients { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<Partner> Partners { get; set; }
    }
}