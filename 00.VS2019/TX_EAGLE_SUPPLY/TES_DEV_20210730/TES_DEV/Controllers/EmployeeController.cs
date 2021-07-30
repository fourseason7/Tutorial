using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TES_DEV.Models;
using static DataLibrary.BusinessLogic.EmployeeProcessor;

namespace TES_DEV.Controllers
{
  public class EmployeeController : Controller
  {
    // GET: Employee
    public ActionResult Index()
    {
      ViewBag.Message = "Employee Lists";

      var data = LoadEmployees();

      List<Employee> employees = new List<Employee>();
      foreach (var row in data)
      {
        employees.Add(new Employee
        {
          Id = row.Id,
          FirstName = row.FirstName,
          LastName = row.LastName,
          EmailAddress = row.EmailAddress,
          PhoneNumber = row.PhoneNumber,
          HireDate = row.HireDate
        }) ;
      }
      return View(employees);
    }
    public ActionResult Create()
    {
      ViewBag.Message = "Employee Register";
    
      return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Employee employee)
    {
      if (ModelState.IsValid)
      {
        int recordCount = CreateEmployee(employee.FirstName, employee.LastName, employee.EmailAddress, employee.PhoneNumber, employee.HireDate);

        return RedirectToAction("Index");
      }
      return View(employee);
    }

    public ActionResult Edit(int Id)
    {

      ViewBag.Message = "Employee Lists";

      if (Id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      var data = LoadEmployees().Where(x => x.Id == Id).FirstOrDefault();

      Employee employees = new Employee();

      if (data != null)
      {
        employees.Id = data.Id;
        employees.FirstName = data.FirstName;
        employees.LastName = data.LastName;
        employees.EmailAddress = data.EmailAddress;
        employees.PhoneNumber = data.PhoneNumber;
        employees.HireDate = data.HireDate;
      }
      return View(employees);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int Id, Employee employee)
    {
      if (Id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      if (ModelState.IsValid)
      {
        int recordCount = UpdateEmployee(Id, employee.FirstName, employee.LastName, employee.EmailAddress, employee.PhoneNumber, employee.HireDate);

        return RedirectToAction("Index");
      }
      return View(employee);
    }
  }
}