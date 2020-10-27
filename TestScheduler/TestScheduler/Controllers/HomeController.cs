using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TestScheduler.Models;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using Microsoft.AspNetCore.Identity;

namespace TestScheduler.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Webpage
        public IActionResult Index()
        {
            var username = GetUsername();
            var classList = GetClassList(username);
            ViewBag.classes = classList;
            ViewBag.accountType = IsStaff(username) ? "Staff Member: " : "Student: ";
            ViewBag.displayName = GetDisplayName(username);
            return View();
        }

        //Webpage
        public IActionResult PasswordManager(string userId)
        {
            ViewBag.userId = userId;

            return View();
        }

        public IActionResult Scheduler()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
