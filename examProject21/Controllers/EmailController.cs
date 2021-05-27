using examProject21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace examProject21.Controllers
{
    public class EmailController : Controller
    {
        private readonly ILogger<EmailController> _logger;

        public EmailController(ILogger<EmailController> logger)
        {
            _logger = logger;
        }

        public IActionResult Iframe()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(SendMailDto sendMailDto)
        {
            if (!ModelState.IsValid) return View();

            /* try
              {
                  MailMessage mail = new MailMessage();

                  mail.From = new MailAddress("noahfenster@hotmail.com");

                  mail.To.Add("yasm2460@stud.kea.dk");

                  mail.CC.Add("moha6248@stud.kea.dk");

                  mail.CC.Add("heri0106@stud.kea.dk");

                  mail.To.Add("deja0191@stud.kea.dk");

                  mail.Subject = sendMailDto.Subject;

                  mail.IsBodyHtml = true;

                  string content = "Name : " + sendMailDto.Name;
                  content += "<br/> Message : " + sendMailDto.Message;

                  mail.Body = content;

                  SmtpClient smtpClient = new SmtpClient("mail.hotmail.dk");

                  NetworkCredential networkCredential = new NetworkCredential("noahfenster@hotmail.com", "@iPhone4");
                  smtpClient.UseDefaultCredentials = false;
                  smtpClient.Credentials = networkCredential;
                  smtpClient.Port = 25;
                  smtpClient.EnableSsl = false;
                  smtpClient.Send(mail);

                  ViewBag.Message = "Mail Send";

                  ModelState.Clear();



              }*/
            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("smtp.office365.com");

                //To Email Address - your need to enter your to email address
                mail.To.Add("dk98@outlook.dk");

                mail.Subject = sendMailDto.Subject;

                //you can specify also CC and BCC - i will skip this
                //mail.CC.Add("");
                //mail.Bcc.Add("");

                mail.IsBodyHtml = true;

                string content = "Name : " + sendMailDto.Name;
                content += "<br/> Message : " + sendMailDto.Message + "<br/> subject : " + sendMailDto.Subject;

                mail.Body = content;


                //create SMTP instant

                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("mail.hotmail.com");

                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("noahfenster@hotmail.com", "@iPhone4");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 25; // this is default port number - you can also change this
                smtpClient.EnableSsl = false; // if ssl required you need to enable it
                smtpClient.Send(mail);

                ViewBag.Message = "Mail Sent";

                // now i need to create the from 
                ModelState.Clear();

            }
            catch (Exception ex)
            {

                ViewBag.Message = "Mail Sent";
            }

            return View();
        }
    }
}
