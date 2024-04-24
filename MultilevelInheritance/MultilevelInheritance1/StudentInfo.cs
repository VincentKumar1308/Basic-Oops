using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class StudentInfo:PersonalInfo
    {
        //properties
        private static int s_registerNumber=2000;
        public string RegisterNumber{get;set;}
        public int Standard{get;set;}
        public string Branch{get;set;}
        public int AcademicYear{get;set;}

        //constructors with auto increment register number
        public StudentInfo(int standard,string branch,int academicYear,string name,string  fathername,long phone,string  mailID,DateTime dob,Gender gender):base(name,fathername,phone,mailID,dob,gender){
            RegisterNumber="REG"+(++s_registerNumber);
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;

        }
        //constructors parameter with register number

         public StudentInfo(string registerNumber,int standard,string branch,int academicYear,string name,string  fathername,long phone,string  mailID,DateTime dob,Gender gender):base(name,fathername,phone,mailID,dob,gender){
            RegisterNumber="REG"+registerNumber;;
            Standard=standard;
            Branch=branch;
            AcademicYear=academicYear;

        }
        public StudentInfo(){
            //without parameter with auto incremented register number
            RegisterNumber="REG"+(++s_registerNumber);
        }

        public StudentInfo(string registerNumber){
            RegisterNumber="REG"+registerNumber;;
        }
        //methods
        public void ShowInfo(){
            System.Console.WriteLine("------------Displaying Student Information--------------");
            System.Console.WriteLine($"Register Number :{RegisterNumber}\nName : {Name}\nFather Name : {FatherName}\nPhone No : {Phone}\nMail ID : {MailID}\nDate of Birth : {DOB}\nGender : {Gender}");

        }
        //methods
        public void GetStudentInfo(){
            System.Console.WriteLine("---------Getting Information from the user----------");
            System.Console.Write("Enter Your Name : ");
            Name=Console.ReadLine();
            System.Console.Write("Enter Your Father Name : ");
            FatherName=Console.ReadLine();
            System.Console.Write("Enter Your Phone Number : ");
            Phone=long.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Mail ID : ");
            MailID=Console.ReadLine();
            System.Console.Write("Enter Your Date Of Birth dd/MM/yyyy : ");
            DOB=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter Your Gender  (male,female,others)");
            Gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter Your standard : ");
           Standard=int.Parse(Console.ReadLine());
           System.Console.Write("Enter Your Branch : ");
           Branch=Console.ReadLine();
           System.Console.Write("Enter Your Academic Year : ");
           AcademicYear=int.Parse(Console.ReadLine());

        }
        
    }
}