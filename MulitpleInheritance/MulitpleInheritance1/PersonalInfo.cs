using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MulitpleInheritance1
{
    public enum Gender {Male,Female}
    public enum MaritalStatus{Married,Single}
    public class PersonalInfo:IShowData
    {
        public string Name{get;set;}
        public DateTime DOB{get;set;}
        public long Phone{get;set;}
        public MaritalStatus maritalStatus;
        public Gender Gender;

        //constructors

        public  PersonalInfo(string name,DateTime dob,long  phoneNo,MaritalStatus status){
            Name=name;
            DOB=dob;
            Phone=phoneNo;
            MaritalStatus maritalStatus=status;

        }

        //methods
        public virtual void ShowInfo(){
            System.Console.WriteLine($"Name : {Name} | DOB : {DOB} | Phone No : {Phone} | Marital Status : {maritalStatus}");
        }

        
    }
}