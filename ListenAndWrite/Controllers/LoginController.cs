using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.DataModel;
using ListenAndWrite.Models.BusinessModel;
using ListenAndWrite.Models.ModelView;

namespace ListenAndWrite.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            /*AccountView cookie = new AccountView()
            {
                account = new Account()
            };
            if (Request.Cookies["account"] !=null)
            {
                cookie.account.Email = Request.Cookies["account"].Values["email"];
                cookie.account.Password = Request.Cookies["account"].Values["password"];
            }*/
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountView accModelView)
        {
            Account account = new AccountDao().Login(accModelView.account.Email, accModelView.account.Password);
            
            if (account != null)
            {
                Session["AccountNow"] = account;
                if (accModelView.Remember)
                {
                    //ViewBag.check = accModelView.Remember.ToString();
                    HttpCookie cookie = new HttpCookie("account");
                    cookie.Values.Add("email",accModelView.account.Email);
                    cookie.Values.Add("password", accModelView.account.Password);
                    cookie.Expires.AddDays(30);
                    Response.Cookies.Add(cookie);
                }
                return RedirectToAction("Index", "Home");
            }
            
            return RedirectToAction("Login", "Login");
        }

        
    }
}