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

namespace TestScheduler.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Get the username
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Replace("UICT\\", "");
            ViewBag.username = username;
            bool isStaff = false;
            //Get usertype stackoverflow.com/questions/5309988/how-to-get-the-groups-of-a-user-in-active-directory-c-asp-net
            List<string> groups = new List<string>();
            List<string> classes = new List<string>();
            WindowsIdentity wi = new WindowsIdentity(username);

            Regex rx = new Regex(@"[A-Z][0-9]{3}");
            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    string txt = group.Translate(typeof(NTAccount)).ToString();
                    txt = txt.Replace("UICT\\", "");
                    if (rx.IsMatch(txt))
                    {
                        classes.Add(txt);
                        Console.WriteLine(txt);
                    }
                    if (txt == "Staff")
                    {
                        isStaff = true;
                    }
                    groups.Add(txt);
                }
                catch (Exception ex) { }
            }
            classes.Sort();
            ViewBag.classes = classes;
            ViewBag.accountType = isStaff ? "Staff" : "Student";


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
