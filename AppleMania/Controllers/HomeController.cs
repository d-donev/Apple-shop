using AppleMania.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AppleMania.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SendEmail(Email model)
        {
            using (MailMessage mm = new MailMessage(model.UserEmail, "gocepaunov18@gmail.com"))
            {
                mm.Subject = model.Subject;
                mm.Body = model.Body;

                mm.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;

                    NetworkCredential cred = new NetworkCredential(model.UserEmail, model.Password);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = cred;
                    smtp.Port = 587;


                    try
                    {
                        smtp.Send(mm);
                        ViewBag.Message = "Email Sent!";
                    }
                    catch (Exception e)
                    {
                        var msg = "Something went wrong!";
                        ViewBag.errorMessage = msg;
                    }
                }
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}