using Klinspot.Models;
using Klinspot.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        [HttpPost]
        public ActionResult Message(ContactMessage contactMessage)
        {
            var body = "<p>Email From: {0} ({1})</p><p>Phone:</p><p>{2}</p><p>Message:</p><p>{3}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("yolchu@nasib.me"));
            message.From = new MailAddress(contactMessage.Email);  // replace with valid value
            message.Subject = contactMessage.Subject;
            message.Body = string.Format(body, contactMessage.Name, contactMessage.Email, contactMessage.Phone,contactMessage.Message);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "cp637762@gmail.com",  // replace with valid value
                    Password = "qThQndqax889F2jU"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.Send(message);
                return Content("bla bla");
            }
        }
    }
}