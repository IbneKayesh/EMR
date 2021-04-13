using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMR.Controllers
{
    public class InvestigationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
