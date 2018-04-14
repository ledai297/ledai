using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.BusinessModel;
using ListenAndWrite.Models.DataModel;

namespace ListenAndWrite.Controllers
{
    public class ChoosingModeController : Controller
    {
        // GET: ChoosingMode
        public ActionResult ChoosingMode(int ListeningID)
        {
            Listening listening = new ListeningDao().GetListeningByID(ListeningID);
            ViewBag.listening = listening;
            
            return View();
        }
        
    }
}