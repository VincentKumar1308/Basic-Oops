using System;
using System.Collections.Generic;
using SingleHeritance1;
namespace SingleHeritance;
class Program{
    public static void Main(string[] args)
    {
        List<StudentInfo> studentInfoList= new List<StudentInfo>();
        StudentInfo student=new StudentInfo(12,"ECE",2020,"VINCENT","JOSEPH",93611968,"vincenthandball2018@gmail.com",new DateTime(2000,11,16),Gender.Male);
        StudentInfo student1=new StudentInfo(11,"EEE",2020,"MUNISH","VELUSAMY",93617768,"MUNISH@gmail.com",new DateTime(2100,11,16),Gender.Male);
       studentInfoList.AddRange(new List<StudentInfo>{student,student1});
       foreach(StudentInfo  studentInfo in studentInfoList){
        studentInfo.ShowDetails();
        System.Console.WriteLine("---------------------------------------------");
       }

    }
}