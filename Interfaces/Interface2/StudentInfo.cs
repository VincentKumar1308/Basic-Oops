using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class StudentInfo:IDisplayInfo
    {
        public static int s_studentID=1000;
        public string StudentID{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public string Mobile{get;set;}

        //constructors
        public StudentInfo(string name,string fatherName,string mobile){
            StudentID="SID"+(++s_studentID);
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
        }

        //methods
        public void Display(){
            System.Console.WriteLine($"Sutdent ID : {StudentID} Name : {Name} Father Name : {FatherName} Mobile Number : {Mobile} ");
        }
    }
}