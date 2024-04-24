using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_studentID=100;
        public string StudentID{get;set;}
        public string Degree{get;set;}
        public string Department{get;set;}
        public string Semester{get;set;}

        //constructors
        public StudentInfo(string degree,string department,string semester,string name,string fatherName,DateTime dob,string mailID,Gender gender):base( name,fatherName, dob,mailID,gender){
            StudentID="SID"+(++s_studentID);
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        //methods
        public void ShowDetails(){
            System.Console.WriteLine($"\n---------Personal Details----------\nName : {Name}\nFather Name :{FatherName}\nDOB : {DOB}\nGender : {Gender}\nMail : {MailID}\n-------------Student INfo-----------\nTeacher ID {StudentID}\nDegree : {Degree}\nDepartment : {Department}\nSemester :{Semester}\n");
        }

    }
}