﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserAuthenication.Models
{
    public class LoginModel
    {
        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public string Username { get; set; }

        public string Role { get; set; }

        public string Isvalid { get; set; }

      

        public string LoginErrorMessage { get; set; }

    }
}