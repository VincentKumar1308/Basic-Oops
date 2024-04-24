using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance1
{
    public class Teacher:PersonalInfo
    {
        public static int s_teacherID=1000;
        public string TeacherID{get;set;}
        public string Department{get;set;}
        public string Teaching{get;set;}
        public string Qualification{get;set;}
        public int YearOfExperince{get;set;}
        public int DateOfJoining{get;set;}

            //constructors
    public Teacher(string department,string teaching,string qualification,int yearOfJoining,int dateOfJoining,string name,string fatherName,DateTime dob,string mailID,Gender gender):base(name,fatherName,dob, mailID,gender){
        TeacherID="TECHID"+(++s_teacherID);
        Department=department;
        Teaching=teaching;
        Qualification=qualification;
        YearOfExperince=yearOfJoining;
        DateOfJoining=dateOfJoining;
        
    }
    //show detailss
    public void ShowDetails(){
        System.Console.WriteLine($"\n-----------PersonalDetails--------------\nName :{Name}\nFatherName : {FatherName}\nDOB : {DOB}\nGender {Gender}\nMailID : {MailID}\n----------Teaching Details------------\nTeacher ID : {TeacherID}\nDepartment : {Department}\nSubject Teaching : {Teaching}\nQualification : {Qualification}\nYear of Experience : {YearOfExperince}\nDate of Joining : {DateOfJoining}");
    }
        
    }

}