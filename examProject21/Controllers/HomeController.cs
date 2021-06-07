using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using examProject21.Models;
using Microsoft.EntityFrameworkCore;

namespace examProject21.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly ConnectionStringClass _cc;
        public HomeController(ConnectionStringClass cc)
        {
            _cc = cc;
        }
       // called during runtime
        public IActionResult Index()
        {
            var results = _cc.Sheet1.ToList();

            return View(results); 
        }
        //search 
        [HttpGet]
        public async Task <IActionResult> Index(String DataSearch)
        {
            ViewData["Getdetails"] = DataSearch;
            var dataQuery = from x in _cc.Sheet1 select x;
            if (!string.IsNullOrEmpty(DataSearch))
            {
                dataQuery = dataQuery.Where(x => x.address.Contains(DataSearch));
            }
            return View( await dataQuery.AsNoTracking().ToListAsync());
        }
    }
}
