using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BootstrapTester.Controllers
{
    public class GridExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
