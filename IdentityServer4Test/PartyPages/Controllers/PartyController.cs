using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyPages.Controllers
{
    public class PartyController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
