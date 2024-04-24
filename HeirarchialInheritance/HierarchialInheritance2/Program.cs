using System;
namespace HierarchialInheritance2;
class Program{
    public static void Main(string[] args)
    {
        TemporaryEmployee temp=new TemporaryEmployee("Temporary",5000,12);
        TemporaryEmployee temp1=new TemporaryEmployee("Temporary",6000,8);
        temp.ShowSalary();
        temp1.ShowSalary();

         PermanentEmployee permanent=new PermanentEmployee("Permanent",5000,12);
        PermanentEmployee permanent1=new PermanentEmployee("Permanent",8000,8);
        permanent.ShowSalary();
        permanent1.ShowSalary();
    }
}