using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    public enum WorkLocation{ChooseLocation,Chennai,Mumbai,Calcutta,Kochin}
    public enum Gender{Select,Male,Female,Transgender}
    public class Payroll
    {
        //field
        private static int s_EmployeeID=1000;

        //auto property
        public string EmployeeID{get;}
        public string EmployeeName{get;set;}
        public string Role{get;set;}
        public string TeamName{get;set;}
        public DateTime DateOfJoin{get;set;}
        public int WorkingDays{get;set;}
        public int NoOfLeave{get;set;}

        public WorkLocation WorkLocation;
        public Gender Gender;

        //constructors
        public Payroll(){
            s_EmployeeID++;
            EmployeeID="SF"+s_EmployeeID;
        }

        //Methods
        public void Registration(){
            System.Console.Write("Enter your Name : ");
            EmployeeName=Console.ReadLine();
            System.Console.Write("Role : ");
            Role=Console.ReadLine();
            Console.WriteLine("Work Location : 1.Chennai 2.Mumbai  3.Calcutta  4.Kochin");
            int workvalue=int.Parse(Console.ReadLine());
            WorkLocation =(WorkLocation)workvalue;
            System.Console.WriteLine("Enter your Gender : 1. Male 2. Femlae 3. Transgender");
            int gendervalue=int.Parse(Console.ReadLine());
            Gender =(Gender)gendervalue;
            System.Console.Write("Enter your team Name : ");
            TeamName=Console.ReadLine();
            System.Console.WriteLine("Enter the Date of Joining dd/MM/yyyyy");
            DateOfJoin=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.WriteLine("Enter the no of working days in the month : ");
            WorkingDays=int.Parse(Console.ReadLine());
            System.Console.Write("Enter the no of days leave : ");
            NoOfLeave=int.Parse(Console.ReadLine());
            System.Console.WriteLine("\n Successfully Registration completed\n");
            System.Console.WriteLine("Your Employee ID is : "+EmployeeID);
            
        }

        public void Display(){
            System.Console.WriteLine("Employee ID   : "+EmployeeID);
            System.Console.WriteLine("Employee Name : "+EmployeeName);
            System.Console.WriteLine("Role          : "+Role);
            System.Console.WriteLine("Work Location : "+WorkLocation);
            System.Console.WriteLine("Team Name     : "+TeamName);
            System.Console.WriteLine("Date Of Join  : "+DateOfJoin);
            System.Console.WriteLine("No Of Working : "+WorkingDays);
            System.Console.WriteLine("No of Leave   : "+NoOfLeave);
            System.Console.WriteLine("Gender        : "+Gender);
            

        }
        
    }
}