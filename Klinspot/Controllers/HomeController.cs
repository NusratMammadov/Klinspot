using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Klinspot.ViewModels;

namespace Klinspot.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        public ActionResult Index()
        {
            Homepage model = new Homepage
            {
                Slides = _context.Slides.OrderByDescending(s => s.Id).ToList(),
                Promos = _context.Services.Where(s => s.IsPromo).OrderByDescending(s => s.Id).Take(3).ToList(),
                AboutText = _context.AboutTexts.FirstOrDefault(),
                Services = _context.Services.OrderByDescending(s => s.Id).ToList(),
                Members = _context.Members.Include("MemberLinks").OrderByDescending(s => s.Id).ToList(),
                Categories = _context.Categories.ToList(),
                Projects = _context.Projects.Include("Category").OrderByDescending(p=>p.Id).ToList(),
                Packages = _context.Packages.OrderBy(p=>p.OrderBy).ToList(),
                Clients  = _context.Clients.OrderByDescending(c=>c.Id).ToList(),
                Blogs = _context.Blogs.OrderByDescending(b=>b.Id).Take(6).ToList(),
                Partners = _context.Partners.ToList()
            };

            return View(model);
        }
    }
}