using System;
namespace PartialClassess1;
class Program{
     public static void Main(string[] args)
     {
        EmployeeInfo employee=new EmployeeInfo("Vincent",Gender.Male,new DateTime(2000,11,16),93611982);
        employee.Display();
        employee.Update();
        System.Console.WriteLine("After Updation");
        employee.Display();
     }
}
