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
            //Get usertype stackoverflow.com/questions/5309988/how-to-get-the-groups-of-a-user-in-active-directory-c-asp-net
            List<string> result = new List<string>();
            WindowsIdentity wi = new WindowsIdentity(username);
            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    result.Add(group.Translate(typeof(NTAccount)).ToString());
                }
                catch (Exception ex) { }
            }
            result.Sort();
            ViewBag.userType = result;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
