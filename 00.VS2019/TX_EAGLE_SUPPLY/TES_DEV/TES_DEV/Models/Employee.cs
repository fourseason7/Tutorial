using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TES_DEV.Models
{
  public class Employee
  {
    public int Id { get; set; }

    [Display(Name = "First Name")]
    [Required(ErrorMessage = "You need to give us your first name.")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "You need to give us your last name.")]
    public string LastName { get; set; }

    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email Address")]
    [Required(ErrorMessage = "You need to give us your email address.")]
    public string EmailAddress { get; set; }

    [DataType(DataType.PhoneNumber)]
    [Display(Name = "Phone Number")]
    [Required(ErrorMessage = "Phone Number Required!")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                       ErrorMessage = "Entered phone format is not valid.")]
    public string PhoneNumber { get; set; }

    [Display(Name ="Hire Date")]
    [DataType(DataType.Date)]
    public DateTime HireDate { get; set; }
  }
}