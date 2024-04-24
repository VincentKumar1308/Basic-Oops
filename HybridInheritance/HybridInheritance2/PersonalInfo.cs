using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance2
{
    public enum Gender{Male,female,Others}
    public class PersonalInfo
    {
        public string Name{get;set;}
        public Gender Gender;
        public  DateTime DOB{get;set;}
        public long MobileNo{get;set;}

        //constructors
        public PersonalInfo(string name,Gender gender,DateTime dob,long mobilenoNO){
            Name=name;
            Gender=gender;
            DOB=dob;
            MobileNo=mobilenoNO;
        }

    }
}