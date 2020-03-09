using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Login.ViewModels
{
    public partial class LoginUser
    {
        [DisplayName("User Name")]
        [Required(ErrorMessage ="User Name is requried.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is requried.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}