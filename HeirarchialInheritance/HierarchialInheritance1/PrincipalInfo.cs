using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance1
{
    public class PrincipalInfo:PersonalInfo
    {
        private static int s_principalID=100;
        public string PrincipalID{get;}
        public string Qualification{get;set;}
        public int YearOfExperience{get;set;}
        public int  DateOfJoining{get;set;}

        //constructors
        public PrincipalInfo(string qualification,int yearOfExperience,int dateOfJoining,string name,string fatherName,DateTime dob,string mailID,Gender gender ):base(name,fatherName,dob,mailID,gender){
            PrincipalID="PID"+(++s_principalID);
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        //methods
        public  void ShowDetails(){
            System.Console.WriteLine($"\n-------Personal INformation-----------\nName : {Name}\nFather Name : {FatherName}\nDoB : {DOB}\nGender : {Gender}\n MailID : {MailID}\n--------------Principal INformation-----------\nPrincipal ID : {PrincipalID}\nQualification : {Qualification}\nYear Of Experience : {YearOfExperience}\nDate of Joining : {DateOfJoining}\n");
        }
    }
}