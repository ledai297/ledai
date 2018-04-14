using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ListenAndWrite.Models.BusinessModel;
using ListenAndWrite.Models.DataModel;

namespace ListenAndWrite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int LevelID=100)
        {
            List<Listening> list = new ListeningDao().GetListeningByLevelID(LevelID);

            return View(list);
        }
        
        
    }
}