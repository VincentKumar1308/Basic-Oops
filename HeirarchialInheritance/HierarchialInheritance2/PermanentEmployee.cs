using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance2
{
    public class PermanentEmployee:SalaryInfo
    {
        private static int s_EmployeeID=1000;
        public string EmployeeID{get;set;}
        public string EmployeeType{get;set;}
        public double DA{get;set;}
        public double HRA{get;set;}
        public double PF{get;set;}
        public double TotalSalary{get;set;}
        //constructors
        public PermanentEmployee(string employeeType,double basicSalary,int month):base(basicSalary,month){
            EmployeeID="PERID"+(++s_EmployeeID);
            EmployeeType=employeeType;
            DA=basicSalary*(0.2/100);
            HRA=basicSalary*(0.18/100);
            PF=(0.1/100)*basicSalary;
            TotalSalary=DA+BasicSalary+HRA-PF;
        }
        //methods
        public void ShowSalary(){
           
            System.Console.WriteLine("Permanent Employee");
             System.Console.WriteLine("------------------------------------");
            System.Console.WriteLine($"Employee ID : {EmployeeID}");
            System.Console.WriteLine($"Total salary of the person is : "+Month*TotalSalary);
            System.Console.WriteLine("-------------------------------------");
        }
        
    }
}