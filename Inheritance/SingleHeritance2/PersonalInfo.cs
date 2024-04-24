using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleHeritance2
{
    public enum Gender{Male,Female}
    public class PersonalInfo
    {
       //properties
       public string Name{get;set;}
       public string FatherName{get;set;}
       public long PhoneNo{get;set;}
       public string MailID{get;set;}
       public DateTime DOB{get;set;}
        public Gender Gender;  

        //Methods
         public PersonalInfo(string name,string fatherName,long phoneNo,string mailID,DateTime dob,Gender gender){
            Name=name;
            FatherName=fatherName;
            PhoneNo=phoneNo;
            MailID=mailID;
            DOB=dob;
            Gender =gender;

    } 
    }
    
   
}