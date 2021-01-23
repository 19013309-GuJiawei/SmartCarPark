using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C200.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmptyLots()
        {
            ViewData["dbtable"] = DBUtl.GetTable("SELECT * FROM LotAvailable ");
            return View();
        }

        public IActionResult Distance()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }



    }
}
