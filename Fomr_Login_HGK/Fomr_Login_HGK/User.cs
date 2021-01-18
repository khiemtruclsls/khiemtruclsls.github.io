﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomr_Login_HGK
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public string Sex { get; set; } 
        public string Address { get; set; }

        public override string ToString()
        {
            return FullName + " : " + UserName;
            //return base.ToString();
        }
    }
}
