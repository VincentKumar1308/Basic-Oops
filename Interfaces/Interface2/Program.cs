using System;
namespace Interface2;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Vincent","Joseph","93611989");
        student.Display();
        EmployeeInfo employee=new EmployeeInfo("SudhandraDevi","Venkat");
        employee.Display();
    }
}