using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance2
{
    public class TemporaryEmployee:SalaryInfo
    {
        private static int s_EmployeeID=1500;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double TotalSalary{get;set;}

        //constructors
        public TemporaryEmployee(string employeeType,double basicSalary,int month):base( basicSalary, month){
            EmployeeID="TEMPID"+(++s_EmployeeID);
            EmployeeType=employeeType;
            DA=(0.15/100)*basicSalary;
            HRA=(0.13/100)*basicSalary;
            PF=(0.1/100)*basicSalary;
            TotalSalary=basicSalary+DA+HRA-PF;

        }
        public void ShowSalary(){
            System.Console.WriteLine("Temporary Employee");
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Employee ID : {EmployeeID}");
            System.Console.WriteLine("Basic Pay is : "+BasicSalary);
            System.Console.WriteLine($"Total Salary of the employee is : "+(TotalSalary*Month));
            System.Console.WriteLine("---------------------------------------------");
        }
    }
}