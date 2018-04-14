using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.DataModel;
using ListenAndWrite.Models.BusinessModel;

namespace ListenAndWrite.Controllers
{
    public class ListeningController : Controller
    {
       
        public ActionResult NewMode(int id)
        {

            return View();
        }
     
        public ActionResult FullMode(int ListeningID)
        {
            
            ViewBag.listening = new ListeningDao().GetListeningByID(ListeningID); 
            return View();
        }

        [HttpPost]
        public ActionResult FullMode(int ID,string test)
        {
            Listening listening = new ListeningDao().GetListeningByID(ID);
            string result = new FullModeModel().GetTable(listening.Solution, test);
            
            return Json(result);
        }
        [HttpPost]
        public ActionResult NewMode()
        {
            return View();
        }
    }
}