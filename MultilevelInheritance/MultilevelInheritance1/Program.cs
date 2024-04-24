using System;
namespace MultilevelInheritance1;
class Program{
    public static void Main(string[] args)
    {
        
        HSCDDetails student1=new HSCDDetails();
        student1.GetStudentInfo();
        student1.ShowInfo();
        student1.Calculate();
        student1.ShowMarkSheet();
        
        HSCDDetails student2=new HSCDDetails();
        student2.GetStudentInfo();
        student2.ShowInfo();
        student2.Calculate();
        student2.ShowMarkSheet();


    }
}