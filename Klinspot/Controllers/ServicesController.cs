using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Klinspot.Models;
using Klinspot.ViewModels;

namespace Klinspot.Controllers
{
    public class ServicesController : BaseController
    {
        // GET: Services
        public ActionResult Index()
        {
            ServiceListPage model = new ServiceListPage
            {
                Services = _context.Services.OrderByDescending(s => s.Id).ToList(),
                Packages = _context.Packages.OrderBy(p => p.OrderBy).ToList()
            };

            model.PageHeader = new PageHeader
            {
                Name = "Services",
                BackgroundPhoto = "header.jpg",
                Breadcrumbs = new Dictionary<string, string>
                {
                    { "Home", Url.Action("index", "home") },
                    { "Services", null }
                }
            };

            return View(model);
        }

        public ActionResult Details(string slug)
        {
            if (slug == null)
            {
                return HttpNotFound();
            }

            Service service = _context.Services.FirstOrDefault(s => s.Slug == slug);

            if (service == null)
            {
                return HttpNotFound();
            }
            ServiceDetailsPage model = new ServiceDetailsPage
            {
                Service = service,
                PageHeader = new PageHeader
                {
                    Name = service.Name,
                    BackgroundPhoto = "header.jpg",
                    Breadcrumbs = new Dictionary<string, string>
                    {
                        { "Home", Url.Action("index", "home") },
                        { "Services", Url.Action("index", "services") },
                        { service.Name,null }
                    }
                }
            };

            return View(model);
        }

        public FileResult Download(int id,string type)
        {
            Service service = _context.Services.Find(id);

            if (service != null)
            {
                string filename = string.Empty;
                string path = string.Empty;
                string fileType = string.Empty;
                if (type == "pdf")
                {
                    filename = service.Slug + ".pdf";
                    path = System.IO.Path.Combine(Server.MapPath("/Uploads"), service.Pdf);
                    fileType = System.Net.Mime.MediaTypeNames.Application.Pdf;
                }
                else
                {
                    filename = service.Slug + ".docx";
                    path = System.IO.Path.Combine(Server.MapPath("/Uploads"), service.Doc);
                    fileType = System.Net.Mime.MediaTypeNames.Application.Octet;
                }
                if (System.IO.File.Exists(path)){
                    byte[] fileBytes = System.IO.File.ReadAllBytes(path);

                    return File(fileBytes, fileType, filename);
                }
            }

            return null;
        }
    }
}