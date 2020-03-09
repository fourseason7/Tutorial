using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_NET_200308.ViewModels.Account
{
    public partial class LoginUserList
        {
        [Required(ErrorMessage ="User Name is requried!")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Password is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}