using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace eFaturanMVC.Controllers
{
    public class efaturaController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kampanyalar()
        {
            return View();
        }

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult Destek()
        {
            return View();
        }

        public ActionResult KVKK()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Index(Models.Email model, HttpPostedFileBase myFiles)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("bilgi@efaturan.com");
            mailim.From = new MailAddress("bilgi@efaturan.com");
            mailim.Subject = "Bize Ulaşın Sayfasından Mesajınız Var. ";
            mailim.Body = "Telefon numaram: " + model.Telefon + " <br>Mail adresim: " + model.Mail + "<br>Konu: " + model.Konu + "<br>Mesaj:" + model.Mesaj;
            mailim.IsBodyHtml = true;

            if (myFiles != null)
            {
                mailim.Attachments.Add(new Attachment(myFiles.InputStream, myFiles.FileName));
            }

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("bilgi@efaturan.com", "d0z3Nb9!");
            smtp.Port = 587;
            smtp.Host = "smtp.efaturan.com";
            smtp.EnableSsl = false;

            try
            {
                smtp.Send(mailim);

                TempData["Message"] = "Mesajınız iletilmiştir. En kısa zamanda size geri dönüş sağlanacaktır.";
            }
            catch (Exception ex)
            {
                TempData["Message"] = "Mesaj gönderilemedi.Hata nedeni:" + ex.Message;
            }


            return Json("asdasd");
        }

        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult Blog2()
        {
            return View();
        }
        public ActionResult eFatura_Nedir()
        {
            return View();
        }
        public ActionResult eFaturaya_Gecis_Zorunlulugu()
        {
            return View();
        }
        public ActionResult Ücretsiz_eFatura_Nasil_Kullanilir()
        {
            return View();
        }
    }
}