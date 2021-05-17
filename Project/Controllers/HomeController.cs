using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _context = _context == null ? new Context() : _context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("USER") != null)
            {
                dynamic model = new ExpandoObject();
                model.Student = JsonConvert.DeserializeObject<Student>(HttpContext.Session.GetString("USER"));
                return View(model);
            }
            return View();
        }

        [NoDirectAccess]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string id, string password)
        {
            if (ModelState.IsValid)
            {
                var student = _context.Students.Where(a => a.ID.Equals(id) && a.Password.Equals(password)).FirstOrDefault();
                if (student != null)
                {
                    HttpContext.Session.SetString("USER", JsonConvert.SerializeObject(student));
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Fail to login");
                }
            }

            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
