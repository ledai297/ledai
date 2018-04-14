using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.DataModel;
using ListenAndWrite.Models.BusinessModel;
namespace ListenAndWrite.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string FirstName,string LastName,string Email,string Password)
        {
            Account account = new Account() {
                FirstName = FirstName,
                LastName = LastName,
                Email = Email,
                Password = Password,

            };
            bool result = new AccountDao().SignUp(account);
            if (result)
            {
                return RedirectToAction("Login","Login");
            }
            return View();
        }
    }
}