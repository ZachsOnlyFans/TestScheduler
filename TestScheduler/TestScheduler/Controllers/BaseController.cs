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
    public class BaseController : Controller
    {
        public string GetUsername()
        {
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Replace("UICT\\", "");
            return username;
        }

        public string GetDisplayName(string username)
        {
            UserPrincipal user = GetUserPrincipal(username);
            return user.DisplayName;
        }

        public List<string> GetClassList(string username)
        {
            //Get usertype stackoverflow.com/questions/5309988/how-to-get-the-groups-of-a-user-in-active-directory-c-asp-net
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
                        //Match with module description
                        classes.Add(txt);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            classes.Sort();
            return classes;
        }

        public bool IsStaff(string username)
        {
            WindowsIdentity wi = new WindowsIdentity(username);
            Regex rx = new Regex(@"[A-Z][0-9]{3}");
            foreach (IdentityReference group in wi.Groups)
            {
                try
                {
                    string txt = group.Translate(typeof(NTAccount)).ToString();

                    txt = txt.Replace("UICT\\", "");
                    if (txt == "ResetStudentPasswords")
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
            return false;
        }

        public IActionResult PasswordReset(string userId)
        {
            ViewBag.userId = userId;
            ViewBag.displayName = GetDisplayName(userId);

            return ResetPassword(userId, "Default1") ? View("Success") : View("PasswordManager");
        }

        public bool ResetPassword(string username, string newPassword)
        {
            try
            {
                //morgantechspace.com/2015/01/reset-ad-user-password-with-C-sharp.html
                //PrincipalContext context = new PrincipalContext(ContextType.Domain);
                //UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
                UserPrincipal user = GetUserPrincipal(username);
                //Enable Account if it is disabled
                user.Enabled = true;
                //Reset User Password
                user.SetPassword(newPassword);
                //Force user to change password at next logon
                user.ExpirePasswordNow();
                //user.Save();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public UserPrincipal GetUserPrincipal(string username)
        {
            PrincipalContext context = new PrincipalContext(ContextType.Domain);
            UserPrincipal user = UserPrincipal.FindByIdentity(context, IdentityType.SamAccountName, username);
            return user;
        }
    }
}
