using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ListenAndWrite.Models.DataModel
{
    public class Listening
    {
        public int ListeningID { set; get; }
        public int LevelID { set; get; }
        public string Tittle { set; get; }
        public string Solution { set; get; }
        //public Byte[] Audio { set; get; }
        public string Url { set; get; }
        //public IFormFile UploadPublicSchedule { set; get; }
    }
}