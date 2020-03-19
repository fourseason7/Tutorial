﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcFormAuthentication_Demo.ViewModels
{
    public class LoginUser
    {
        [Required(ErrorMessage ="User Name is required!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}