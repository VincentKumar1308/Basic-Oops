using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance1
{
    public enum Gender{Male,Female,Others}
    public class PersonalInfo
    {
        private static int s_registerNumber=1000;
        public string RegistrationNumber{get;set;}
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long PhoneNo{get;set;}
        public int DOB{get;set;}
        public Gender Gender;

        //constructors
        public  PersonalInfo(string name,string fatherName,long phoneNo,int dob,Gender gender){
            RegistrationNumber="REGNo"+(++s_registerNumber);
            Name=name;
            FatherName=fatherName;
            PhoneNo=phoneNo;
            DOB=dob;
            Gender=gender;
        }
        
    }
}