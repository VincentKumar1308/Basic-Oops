using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MulitpleInheritance1
{
    public class RegisterPerson:PersonalInfo,IShowData,IfamilyInfo
    {
        private static int s_registrationNumber=100;
        public string RegistrationNumber{get;set;}
        public DateTime DateOfRegistration{get;set;}
        public string FatherName{get;set;}
        public string MotherName{get;set;}
        public string HouseAddress{get;set;}
        public int NoOfSiblings{get;set;}

        //constructors
        public RegisterPerson(DateTime  dateOfRegistration,string name, DateTime dob,long phone,MaritalStatus status, Gender gender,string fatherName,string motherName,string houseAddress,int noOfSiblings):base(name,dob,phone,status){
            DateOfRegistration=dateOfRegistration;
            RegistrationNumber="REGNO : "+(++s_registrationNumber);
        
        }
        public override void ShowInfo(){
            System.Console.WriteLine("Name : "+Name+" Gender  : "+Gender+" DOB : "+DOB.ToString("dd/MM/yyyy")+"\n Phone : "+Phone+" Marital Status : "+maritalStatus+" Father Name : "+FatherName+" Mother Name : "+MotherName+"\nHouse Address : "+HouseAddress+" No of Siblings : "+NoOfSiblings+"Date Of Registration : "+DateOfRegistration.ToString("dd/MM/yyyy")+" Registration Number : "+RegistrationNumber);

        }

       
        
    }
}