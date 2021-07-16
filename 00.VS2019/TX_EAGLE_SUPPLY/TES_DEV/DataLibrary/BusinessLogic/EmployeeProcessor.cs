using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;

namespace DataLibrary.BusinessLogic
{
  public static class EmployeeProcessor
  {
    public static int CreateEmployee(string firstName, string lastName, string emailAddress, string phoneNumber, DateTime hireDate)
    {
      Employee data = new Employee
      {
        FirstName = firstName,
        LastName = lastName,
        EmailAddress = emailAddress,
        PhoneNumber = phoneNumber,
        HireDate = hireDate
      };

      string sql = @"INSERT INTO dbo.Employee
                           (FirstName
                           ,LastName
                           ,EmailAddress
                           ,PhoneNumber
                           ,HireDate)
                    VALUES
                          (@FirstName
                          , @LastName
                          , @EmailAddress
                          , @PhoneNumber
                          , @HireDate)";

      return SqlDataAccess.SaveData(sql, data);
    }

    public static int UpdateEmployee(int Id, string firstName, string lastName, string emailAddress, string phoneNumber, DateTime hireDate)
    {
      Employee data = new Employee
      {
        Id = Id,
        FirstName = firstName,
        LastName = lastName,
        EmailAddress = emailAddress,
        PhoneNumber = phoneNumber,
        HireDate = hireDate
      };

      string sql = @"UPDATE dbo.Employee
                        SET FirstName = @FirstName
                          ,LastName = @LastName
                          ,EmailAddress = @EmailAddress
                          ,PhoneNumber = @PhoneNumber
                          ,HireDate = @HireDate
                      WHERE Id = @Id";

      return SqlDataAccess.SaveData(sql, data);
    }

    public static List<Employee> LoadEmployees()
    {
      string sql = @"SELECT Id
                        ,FirstName
                        ,LastName
                        ,EmailAddress
                        ,PhoneNumber
                        ,HireDate
                    FROM TESDemoDB.dbo.Employee";

      return SqlDataAccess.LoadData<Employee>(sql);
    }
  }
}
