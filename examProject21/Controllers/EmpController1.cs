using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using examProject21.Models;
using Microsoft.EntityFrameworkCore;

namespace examProject21.Controllers
{
    public class EmpController1 : Controller
    {
        public String UserName = "admin";
        public String Password = "admin";

        private readonly ConnectionStringClass _cc;
        public EmpController1(ConnectionStringClass cc)
        {
            _cc = cc;

        }


       
        public IActionResult Index()
        {
            var results = _cc.Sheet1.ToList();

            return View(results); 
        }

        
        [HttpGet]
        public async Task <IActionResult> Index(String Empsearch)
        {
            ViewData["Getdetails"] = Empsearch;
            var empquery = from x in _cc.Sheet1 select x;
            if (!string.IsNullOrEmpty(Empsearch))
            {
                empquery = empquery.Where(x => x.address.Contains(Empsearch));
            }
            return View( await empquery.AsNoTracking().ToListAsync());
        }
        
        [HttpGet]
        public ActionResult loginForm()
        {
            return View(); // By default, it returns a View with same name as action name
        } 

    }
}
