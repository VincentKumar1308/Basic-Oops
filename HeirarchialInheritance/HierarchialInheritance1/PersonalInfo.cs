using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchialInheritance1
{

    public enum Gender {Male,Femle,Others}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public DateTime  DOB{get;set;}
        public Gender Gender;
        public string MailID{get;set;}

        //constructor
        public PersonalInfo(string name,string fatherName,DateTime dob,string mailID,Gender gender){
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            MailID=mailID;
            Gender=gender;
        }
        
    }
}