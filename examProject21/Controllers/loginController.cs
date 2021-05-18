using examProject21.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examProject21.Controllers
{
    public class loginController : Controller
    {
        public String UserName = "admin";
        public String Password = "admin";

        [HttpGet]
        public ActionResult loginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult loginForm(Login login)
        {
            if(login.UserName == UserName && login.Password == Password)
            {
            return View(new Uri("https://www.youtube.com/"));

            }
            else{
            return View();
        }
       }   
    
}
}



