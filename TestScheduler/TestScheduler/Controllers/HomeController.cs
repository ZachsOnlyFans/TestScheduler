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
            string displayName = UserPrincipal.Current.DisplayName;
            ViewBag.username = displayName;
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
                    //Debug.WriteLine(txt);
                    txt = txt.Replace("UICT\\", "");

                    if (rx.IsMatch(txt))
                    {
                        //Match with module description
                        classes.Add(txt);
                        //Debug.WriteLine(txt);
                    }
                    if (txt == "ResetStudentPasswords")
                    {
                        isStaff = true;
                    }
                    groups.Add(txt);
                }
                catch (Exception ex) {
                    Debug.WriteLine(ex.ToString());
                }
            }
            classes.Sort();
            ViewBag.classes = classes;
            ViewBag.accountType = isStaff ? "Staff Member: " : "Student: ";


            return View();
        }

        public IActionResult PasswordManager(string userId)
        {
            ViewBag.userId = userId;

            return View();
        }

        public IActionResult PasswordReset(string userId)
        {
            ViewBag.userId = userId;

            return ResetPassword(userId, "Default1") ? View("Success") : View("PasswordManager");
        }

        public static bool ResetPassword(string userName, string newPassword)
        {
            try {
                //morgantechspace.com/2015/01/reset-ad-user-password-with-C-sharp.html
                PrincipalContext context = new PrincipalContext(ContextType.Domain);
                UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, userName);
                //Enable Account if it is disabled
                user.Enabled = true;
                //Reset User Password
                user.SetPassword(newPassword);
                //Force user to change password at next logon
                user.ExpirePasswordNow();
                //user.Save();
                return true;
            } catch {
                return false;
            }
        }

        public static bool UserIsStaff()
        {
            bool isStaff = false;
            WindowsIdentity wi = new WindowsIdentity(System.Security.Principal.WindowsIdentity.GetCurrent().Name); 
            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    string txt = group.Translate(typeof(NTAccount)).ToString();
                    //Debug.WriteLine(txt);
                    txt = txt.Replace("UICT\\", "");
                    if (txt == "ResetStudentPasswords")
                    {
                        isStaff = true;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }

            return isStaff;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
