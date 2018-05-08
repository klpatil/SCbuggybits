using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCbuggybits.Models
{
    public class UserDetail
    {
        public string UserName { get; set; }

        public bool IsLoggedin { get { return !string.IsNullOrWhiteSpace(UserName); } }
    }
}