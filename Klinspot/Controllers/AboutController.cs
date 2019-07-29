using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Klinspot.ViewModels;

namespace Klinspot.Controllers
{
    public class AboutController : BaseController
    {
        // GET: About
        public ActionResult Index()
        {
            AboutPage model = new AboutPage
            {
                AboutText = _context.AboutTexts.FirstOrDefault(),
                Members = _context.Members.Include("MemberLinks").OrderByDescending(s => s.Id).ToList(),
                Clients = _context.Clients.OrderByDescending(c => c.Id).ToList(),
                Partners = _context.Partners.ToList()
            };

            model.PageHeader = new PageHeader
            {
                Name = "About us",
                BackgroundPhoto = "header.jpg",
                Breadcrumbs = new Dictionary<string, string>
                {
                    { "Home", Url.Action("index", "home") },
                    { "About us", null }
                }
            };

            return View(model);
        }
    }
}