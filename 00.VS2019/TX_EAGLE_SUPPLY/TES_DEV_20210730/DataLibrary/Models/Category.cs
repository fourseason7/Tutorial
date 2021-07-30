using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public int ModifiedUserId { get; set; }
    public string ModifiedHostName { get; set; }
    public DateTime ModifiedDate { get; set; }
  }
}
