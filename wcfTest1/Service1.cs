using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfTest1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetSystemDate()
        {
            return string.Format("Current Date Time: {0}", DateTime.Now.ToShortDateString());
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public clsEmployee GetEmployee(string emp_id)
        {
            pubsEntities pubs = new pubsEntities();

            var sqlScripts = (from a in pubs.employees
                              where a.emp_id == emp_id
                              select new
                              {
                                  EmployeeID = a.emp_id
                                  ,
                                  FirstName = a.fname
                                  ,
                                  LastName = a.lname
                              }).FirstOrDefault();

            clsEmployee employee = new clsEmployee();

            employee.EmployeeID = sqlScripts.EmployeeID;
            employee.FirstName = sqlScripts.FirstName;
            employee.LastName = sqlScripts.LastName;

            return employee;
        }

        public List<clsEmployee> GetEmployees(string emp_id = "")
        {
            pubsEntities pubs = new pubsEntities();

            var sqlScripts = (from a in pubs.employees
                              where a.emp_id.Contains(emp_id)
                              select new
                              {
                                  EmployeeID = a.emp_id
                                  ,
                                  FirstName = a.fname
                                  ,
                                  LastName = a.lname
                              }).ToList();

            List<clsEmployee> empLists = new List<clsEmployee>();
            clsEmployee emp = new clsEmployee();
            foreach (var item in sqlScripts)
            {
                emp.EmployeeID = item.EmployeeID;
                emp.FirstName = item.FirstName;
                emp.LastName = item.LastName;

                empLists.Add(emp);
            }

            return empLists;
        }
    }
}
