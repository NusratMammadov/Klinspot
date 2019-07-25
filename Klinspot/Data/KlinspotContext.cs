using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Klinspot.Models;

namespace Klinspot.Data
{
    public class KlinspotContext:DbContext
    {
        public KlinspotContext() : base("KlinspotContext")
        {

        }

        public DbSet<AboutText> AboutTexts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberLink> MemberLinks { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SocialLink> SocialLinks { get; set; }
    }
}