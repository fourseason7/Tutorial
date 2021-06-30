using System;
using System.Collections.Generic;

#nullable disable

namespace HRM_P4N.Models
{
    public partial class Company
    {
        public Company()
        {
            BranchCompanies = new HashSet<BranchCompany>();
            CompanyPaySeqs = new HashSet<CompanyPaySeq>();
            DailyStatusLogs = new HashSet<DailyStatusLog>();
            Employees = new HashSet<Employee>();
            Surveys = new HashSet<Survey>();
        }

        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int CompanyTypeId { get; set; }
        public int PayPeriodTypeId { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime? TerminateDate { get; set; }
        public bool ActiveFlag { get; set; }
        public string HostName { get; set; }
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }

        public virtual RefCompanyType CompanyType { get; set; }
        public virtual RefPayPeriodType PayPeriodType { get; set; }
        public virtual GroupCompany GroupCompany { get; set; }
        public virtual ICollection<BranchCompany> BranchCompanies { get; set; }
        public virtual ICollection<CompanyPaySeq> CompanyPaySeqs { get; set; }
        public virtual ICollection<DailyStatusLog> DailyStatusLogs { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Survey> Surveys { get; set; }
    }
}
