using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.DataModel;
using ListenAndWrite.Models.ModelView;
namespace ListenAndWrite.Controllers
{
    public class LogoutController : Controller
    {
        // GET: Logout
        public ActionResult Logout(Account account)
        {
            if (account != null)
            {
                Session.Remove("AccountNow");
                return RedirectToAction("Login", "Login");
            }

            return RedirectToAction("Login", "Login");
        }
    }
}