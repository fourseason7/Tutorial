using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
  public static class EmployeeTypeProcessor
  {
    public static List<EmployeeType> LoadEmployeeTypes()
    {
      string sql = @"select Id, EmployeeTypeName, EmployeeTypeDescription
                          from dbo.EmployeeType;";

      return SqlDataAccess.LoadData<EmployeeType>(sql);
    }
  }
}
