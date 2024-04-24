using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classCollegeAdmission
{
    //enum
    public enum Gender{Male,Female,Transgender}
    public class StudentDetails
    {
        /*
        a.	StudentName
        b.	FatherName
        c.	DOB
        d.	Gender – Enum (Select, Male, Female, Transgender)
        e.	Physics
        f.	Chemistry
        g.	Maths */

       //field

       //static field
        private static int s_studentID=3000;//ReadOnly Property

        //autoproperty
        public string StudentID{get;}
        public string StudentName{get;set;}
        public string FatherName{get;set;}
        public DateTime DOB{get;set;}
         public Gender Gender{get;set;}
        public int Physics{get;set;}
        public int  Chemistry{get;set;}
        public int Maths{get;set;}
       

        //constructors
        public   StudentDetails(string studentName,string fatherName,DateTime dob,Gender gender,int physics,int  chemistry,int maths){
            //Auto Increment 
            s_studentID++;

            StudentID="SF"+s_studentID;
            FatherName=fatherName;
            StudentName=studentName;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }

        //methods
        public double Average(){
            int total=Physics+Chemistry+Maths;
            double average=(double)total/3;
            return average;
        }

        public bool CheckEligibility(double  cutOff){
            if(Average()>=cutOff){
                return true;
            }
            else{
                return false;
            }
        }
        
    }
}