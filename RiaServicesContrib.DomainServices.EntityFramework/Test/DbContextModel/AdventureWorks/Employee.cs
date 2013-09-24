//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DbContextModels.AdventureWorks
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Reports = new HashSet<Employee>();
            this.EmployeeAddresses = new HashSet<EmployeeAddress>();
            this.EmployeeDepartmentHistories = new HashSet<EmployeeDepartmentHistory>();
            this.EmployeePayHistories = new HashSet<EmployeePayHistory>();
            this.JobCandidates = new HashSet<JobCandidate>();
            this.PurchaseOrders = new HashSet<PurchaseOrder>();
        }
    
        public int EmployeeID { get; set; }
        public string NationalIDNumber { get; set; }
        public int ContactID { get; set; }
        public string LoginID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string Title { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public System.DateTime HireDate { get; set; }
        public bool SalariedFlag { get; set; }
        public short VacationHours { get; set; }
        public short SickLeaveHours { get; set; }
        public bool CurrentFlag { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Contact Contact { get; set; }
        public virtual ICollection<Employee> Reports { get; set; }
        public virtual Employee Manager { get; set; }
        public virtual ICollection<EmployeeAddress> EmployeeAddresses { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
        public virtual ICollection<EmployeePayHistory> EmployeePayHistories { get; set; }
        public virtual ICollection<JobCandidate> JobCandidates { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}
