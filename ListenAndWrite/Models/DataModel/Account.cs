using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ListenAndWrite.Models.DataModel
{
    public class Account
    {
        public int AccountID { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public DateTime Birth { set; get; }
        public bool Remember { set; get; }
    }
}