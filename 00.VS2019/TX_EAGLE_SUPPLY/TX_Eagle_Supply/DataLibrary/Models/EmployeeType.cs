using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
  public class EmployeeType
  {
    public int Id { get; set; }
    public string EmployeeTypeName { get; set; }
    public string EmployeeTypeDescription { get; set; }
    public Nullable<System.DateTime> ModifiedDate { get; set; }
  }
}
