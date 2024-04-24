using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess1
{
    public partial class EmployeeInfo
    {
        public void Display(){
            System.Console.WriteLine($"\n-------Employee Details----------\nEmployee ID : {EmployeeID}\nName : {Name}\nGender :{Gender}\nDOB : {DOB.ToString("dd//MM/yyyy")}\nMobile No : {PhoneNo}\n");
        }
        public void Update(){
            System.Console.WriteLine("------Updating  the Information--------");
            System.Console.Write("Enter the Name : ");
            Name=Console.ReadLine();
            System.Console.Write("Enter the Gender : ");
            Gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter the DOB dd/MM/yyyy : ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter the Mobile No : ");
            PhoneNo=long.Parse(Console.ReadLine());
        }     
    }
}