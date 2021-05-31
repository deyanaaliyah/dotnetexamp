using examProject21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using MimeKit;
using MailKit.Net.Smtp;

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
            // Creating a variable using the MimeKit library
            var message = new MimeMessage();

            // Sending the mail from our default/fake mail
            message.From.Add(new MailboxAddress("Raadgivning", "noahfensterleigh@gmail.com"));

            // CC everyone in the group + the sender
            message.To.Add(new MailboxAddress("Mail sendt til", sendMailDto.Email));
            message.To.Add(new MailboxAddress("Mail sendt til", "deja0191@stud.kea.dk"));
            //message.To.Add(new MailboxAddress("Mail sendt til", "moha6248@stud.kea.dk"));
            //message.To.Add(new MailboxAddress("Mail sendt til", "heri0106@stud.kea.dk"));
            //message.To.Add(new MailboxAddress("Mail sendt til", "yasm2460@stud.kea.dk"));

            // Instantiate the subject - should be kept default to filter the mailbox nicely!
            message.Subject = "Ny booking fra websiden!";

            // Inserting the body inside the mail using the TextPart class
            message.Body = new TextPart("plain")
            {
                Text = "Navn: " + sendMailDto.Name +
                    "\nEmail: " + sendMailDto.Email +
                    "\nAdresse: " + sendMailDto.Address +
                    "\n\nBesked: " + sendMailDto.Message
            };

            // Creating the mail server called client - very important to keep these private since it's very confidential
            using (var client = new SmtpClient())
            {
                // Mail server fields. Port number, SSL, etc.
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("noahfensterleigh@gmail.com", "@iPhone4");
                client.Send(message);
                client.Disconnect(true);
            };

            ViewBag.HideForm = ".form-group, button{ display: none;}";
            ViewBag.SuccessfullySent = "Tak! Du har nu provet at sende os en mail";
            ViewBag.Message = "Hvis ikke du selv modtager en bekraeftelse, bedes du prove igen \n1-3 hverdages ventetid";

            return View();
        }
    }
}
