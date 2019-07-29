using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Klinspot.Models;
using Klinspot.ViewModels;

namespace Klinspot.Controllers
{
    public class NewsController : BaseController
    {
        // GET: News
        public ActionResult Index(int page=1)
        {
            int newsPerPage = 1;
            NewsListPage model = new NewsListPage
            {

                Blogs = _context.Blogs.OrderByDescending(b => b.Date).Skip((page-1)* newsPerPage).Take(newsPerPage).ToList(),
                PageHeader = new PageHeader
                {
                    Name = "News",
                    BackgroundPhoto = "header.jpg",
                    Breadcrumbs = new Dictionary<string, string>
                    {
                        { "Home", Url.Action("index", "home") },
                        { "News", null }
                    }
                },
                TotalPage = (int)Math.Ceiling(_context.Blogs.Count()/(double)newsPerPage),
                ActivePage = page
            };

            return View(model);
        }

        public ActionResult Details(string slug)
        {
            if (slug == null)
            {
                return HttpNotFound();
            }

            Blog blog = _context.Blogs.FirstOrDefault(b => b.Slug == slug);

            if(blog == null)
            {
                return HttpNotFound();
            }

            Blog prev = _context.Blogs.OrderByDescending(b=>b.Id).FirstOrDefault(b => b.Id < blog.Id);
            Blog next = _context.Blogs.OrderBy(b=>b.Id).FirstOrDefault(b => b.Id > blog.Id);

            NewsDetailsPage model = new NewsDetailsPage
            {
                Blog = blog,
                PageHeader = new PageHeader
                {
                    Name = blog.Title,
                    BackgroundPhoto = "header.jpg",
                    Breadcrumbs = new Dictionary<string, string>
                    {
                        { "Home", Url.Action("index", "home") },
                        { "News", Url.Action("index", "news") },
                        { blog.Title,null }
                    }
                },
                PrevUrl = prev!=null?Url.Action("details","news",new { slug = prev.Slug }):null,
                NextUrl = next != null ? Url.Action("details", "news", new { slug = next.Slug }) : null,
            };

            return View(model);
        }
    }
}