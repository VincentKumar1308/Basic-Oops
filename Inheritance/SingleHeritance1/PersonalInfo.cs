using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleHeritance1
{
    public enum Gender{Male,Female,Others}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long PhoneNo{get;set;}
        public string MailID{get;set;}
        public DateTime DOB{get;set;}
        public Gender Gender;

        //constructor
        public PersonalInfo(string name,string fatherName,long phoneNO,string mailID,DateTime dob,Gender gender){
            Name=name;
            FatherName=fatherName;
            PhoneNo=phoneNO;
            MailID=mailID;
            DOB=dob;
            Gender=gender;
        }
    }
}