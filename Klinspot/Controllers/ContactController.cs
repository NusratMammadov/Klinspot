using Klinspot.Models;
using Klinspot.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Klinspot.Controllers
{
    public class ContactController : BaseController
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactPage model = new ContactPage
            {
                PageHeader = new PageHeader
                {
                    Name = "Contact us",
                    BackgroundPhoto = "header.jpg",
                    Breadcrumbs = new Dictionary<string, string>
                    {
                        { "Home", Url.Action("index", "home") },
                        { "Contact us", null }
                    }
                },
                Setting = ViewBag.Setting as Setting,
                SocialLinks = ViewBag.SocialLinks as List<SocialLink>
            };

            return View(model);
        }
    }
}