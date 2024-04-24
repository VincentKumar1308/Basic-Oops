using System;
namespace PartialClassess2;
class  Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Vincent",StudentInfo.Gender.Male,new DateTime(2000,11,16),936119,98,97,87);
        student.Total();
        student.Percentage();
    }
}