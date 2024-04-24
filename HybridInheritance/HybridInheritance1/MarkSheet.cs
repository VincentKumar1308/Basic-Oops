using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance1
{
    public class MarkSheet:TheoryExams,ICalculate
    {
        private static int s_markSheetNumber=100;
        public string MarkSheetNumber{get;set;}
        public DateTime DateOfIssue{get;set;}
        public int total{get;set;}
        public double Percentage{get;set;}
        public int ProjectMark{get;set;}

        //constructor
        public MarkSheet(DateTime dateOfIssue,int[] sem1,int[] sem2,int[] sem3,int[] sem4,int projectMark,string name,string fatherName,long phoneNo,int dob,Gender gender):base( sem1, sem2, sem3, sem4, name, fatherName, phoneNo, dob, gender){
            MarkSheetNumber="MarsheetNO"+(++s_markSheetNumber);
            DateOfIssue=dateOfIssue;
            ProjectMark=projectMark;
            
          
        }
        //methods
       public void ShowUGMarkSheet(){
        System.Console.WriteLine("---------------------UG Mark Sheet---------------");
        System.Console.WriteLine("Registration Number : "+RegistrationNumber);
        System.Console.WriteLine("Name : "+Name);
        System.Console.WriteLine("Father Name : "+FatherName);
        System.Console.WriteLine("Phone : "+PhoneNo);
        System.Console.WriteLine("Gender : "+Gender);
       Total();
       System.Console.WriteLine("---------------------------------------------------");
    

       }
       public void Total(){
        int sum=0;
        foreach(int num in Sem1){
            sum=sum+num;
        }
        
        foreach(int num in Sem2){
            sum=sum+num;
        }
        foreach(int num in Sem3){
            sum=sum+num;
        }
        foreach(int num in Sem4){
            sum=sum+num;
        }
        total=sum+ProjectMark;
         System.Console.WriteLine("The total marks is out of 2400 is : "+total);
        System.Console.WriteLine("Total percentage is : "+(total/24));
       }

    }
}