using examProject21.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace examProject21.Controllers
{
    public class LoginController : Controller
    {
        public String UserName = "admin";
        public String Password = "admin";

        [HttpGet]
        public ActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginForm(Login login)
        {
            if(login.UserName == UserName && login.Password == Password)
            {
                return View("Test",login);
            }
            else
            {
                return View();
            }
        }   
    }
}



