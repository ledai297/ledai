using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListenAndWrite.Models.DataModel
{
    public class DetailScore
    {
        public int DetailScoreID { set; get; }
        public int AccountID { set; get; }
        public int ListeningID { set; get; }
        public DateTime ListeningDay { set; get; }
        public int Score { set; get; }
    }
}