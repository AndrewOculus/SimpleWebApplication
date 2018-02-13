using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LasexWebFormApp.Models
{
    public class User
    {


        public string login { get; set; }
        public string password { get; set; }
        public string permission { get; set; }

        public User(string pass, string permiss)
        {
            this.password = pass;
            this.permission = permiss;
        }

    }
}