using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace BindReader.Controllers
{
    public class HomeController : Controller
    {
        private Class myClass;

        public HomeController(IOptions<Class> myClass)
        {
            this.myClass = myClass.Value;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}