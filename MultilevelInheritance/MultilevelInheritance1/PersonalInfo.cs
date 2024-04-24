using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public enum Gender{Male,Female,Others}
    public class PersonalInfo
    {
        //properties
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Phone{get;set;}
        public string MailID{get;set;}
        public DateTime DOB{get;set;}
        public Gender Gender;

        //constructors
        public  PersonalInfo(string name,string  fathername,long phone,string  mailID,DateTime dob,Gender gender){
            Name=name;
            FatherName=fathername;
            Phone=phone;
            MailID=mailID;
            DOB=dob;
            Gender=gender;
          
        }
        public PersonalInfo(){
            //default
            
        }
       
    }
}