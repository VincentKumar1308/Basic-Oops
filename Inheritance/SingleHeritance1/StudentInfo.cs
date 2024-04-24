using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SingleHeritance1
{
    public class StudentInfo:PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegisterNumber{get;set;}
        public int Standard{get;set;}
        public string Branch{get;set;}
        public int AcademicYear{get;set;}
       


        //constructor
        public StudentInfo(int standard,string branch,int academicYear,string name,string fatherName,int phoneNo,string mailID,DateTime dob,Gender gender):base( name, fatherName, phoneNo, mailID, dob, gender)
        {
            s_registerNumber++;
            RegisterNumber="REG"+s_registerNumber;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;
            

            
        }
        public void ShowDetails(){
            System.Console.WriteLine($"Name : {Name}\nFather Name : {FatherName}\nPhone : {PhoneNo}\nMailID : {MailID}\nDate Of Brith : {DOB.ToString("dd/MM/yyyy")}\nGender : { Gender} \nRegister Number : {RegisterNumber}\nStandard : {Standard}\nBranch : {Branch}\nAcademic Year : {AcademicYear} ");
        }
    }
}