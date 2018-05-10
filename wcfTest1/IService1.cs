using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfTest1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string GetSystemDate();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        clsEmployee GetEmployee( string emp_id);

        [OperationContract]
        List<clsEmployee> GetEmployees(string emp_id);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    public class Calc
    {
        [DataMember]
        public double n1;
        [DataMember]
        public double n2;

    }
    public class clsEmployee
    {
        private string _strEmpId;
        private string _strFirstName;
        private string _strLastName;

        [DataMember]
        public string EmployeeID
        {
            get { return _strEmpId; }
            set { _strEmpId = value; }
        }
        [DataMember]
        public string FirstName
        {
            get { return _strFirstName; }
            set { _strFirstName = value; }
        }
        [DataMember]
        public string LastName
        {
            get { return _strLastName; }
            set { _strLastName = value; }
        }

    }
}
