using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
         //   var obj = new obj() { id = 1, name = "bas" };
            return View();
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult contactus()
        {
            return View();
        }
    }
}
