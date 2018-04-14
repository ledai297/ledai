using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListenAndWrite.Models.DataModel;
using System.ComponentModel.DataAnnotations;

namespace ListenAndWrite.Models.ModelView
{
    public class AccountView
    {
        public Account account {
            set;
            get;
        }
        [Display(Name ="Remember me?")]
        public bool Remember
        {
            set;get;
        }
    }
}