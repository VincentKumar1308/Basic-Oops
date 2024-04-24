using System;
using MulitpleInheritance1;
namespace MultipleInheritance1;
class Program{
    public static void Main(string[] args)
    {
        RegisterPerson register=new RegisterPerson(DateTime.Now,"vincent",new DateTime(2000,11,16),93611982,MaritalStatus.Single,Gender.Male,"joseph","navamani","tiruvannamalai",0);
        RegisterPerson register1=new RegisterPerson(DateTime.Now,"sudha",new DateTime(2002,08,14),87511982,MaritalStatus.Single,Gender.Female,"venkat","abirami","tiruvannamalai",1);
        register.ShowInfo();
        register1.ShowInfo();
    }
}