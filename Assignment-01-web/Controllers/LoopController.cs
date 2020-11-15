using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment_01_web.Controllers
{
    public class LoopController : Controller
    {

       
        
        // GET: /<controller>/
        public IActionResult Loop()
        {
         List<string> loopItems = new List<String>();
            loopItems.Add("Controller Loop item 1");
            loopItems.Add("Controller Loop item 2");
            loopItems.Add("Controller Loop item 3");
            loopItems.Add("Controller Loop item 4");
            loopItems.Add("Controller Loop item 5");
            loopItems.Add("Controller Loop item 6");
            ViewBag.controllerLoopItems = loopItems;
            return View();
        }


    }
}
