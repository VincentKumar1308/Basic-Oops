using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class EmployeeInfo:IDisplayInfo
    {
        //properties
        private static int s_employeeID=100;
        public string EmployeeID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}

        //constructors
        public EmployeeInfo(string name,string fatherName){
            Name=name;
            FatherName=fatherName;
            EmployeeID="EID"+(++s_employeeID);
        }

        //methods
        public void Display(){
            System.Console.WriteLine($"Employee ID : {EmployeeID} Name : {Name} Father Name : {FatherName}");
        }
    }
}