using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class HSCDDetails:StudentInfo
    {
        //properties
        private static int s_hscMarkSheetNumber=3000;
        public string HscMarkSheetNumber{get;set;}
        public int PhysicsMarks{get;set;}
        public int ChemistryMarks{get;set;}
        public int MathsMarks{get;set;}
        public int Total{get;set;}
        public double Percentage{get;set;}

        //constructors
        //default constructor
        public HSCDDetails(){

        }

        //parametrized constructor
        public  HSCDDetails(int physicsMarks,int chemistryMarks,int mathsMarks,int standard,string branch,int academicYear,string name,string  fathername,long phone,string  mailID,DateTime dob,Gender gender):base( standard, branch, academicYear,name,fathername,phone,mailID,dob,gender){

        }
    
        //Methods

        public void GetMarks(){
            System.Console.WriteLine("-----------Getting the marks from the User-----------");
            System.Console.Write("Enter the physics Marks : ");
            PhysicsMarks=int.Parse(Console.ReadLine());
            System.Console.Write("Enter the Chemistry Marks : ");
            ChemistryMarks=int.Parse(Console.ReadLine());
            System.Console.Write("Enter the Maths Marks : ");
            MathsMarks=int.Parse(Console.ReadLine());
        }
        public void Calculate(){
            System.Console.WriteLine("Calculating the marks");
            if(PhysicsMarks==0 && ChemistryMarks==0 && MathsMarks==0){
            GetMarks();
            }
            Total=PhysicsMarks+ChemistryMarks+MathsMarks;
            System.Console.WriteLine("your total Mark is : "+Total);
            System.Console.WriteLine("Yout Percentage is : "+(double)Total/3.0);
            
        }
        public void ShowMarkSheet(){
            System.Console.WriteLine("Register Number : "+RegisterNumber);
            System.Console.WriteLine("Name : "+Name);
            System.Console.WriteLine("Standard : "+Standard);
            System.Console.WriteLine("Branch :"+Branch);
            System.Console.WriteLine("Physics Mark : "+PhysicsMarks);
            System.Console.WriteLine("Chemistry Mark : "+ChemistryMarks);
            System.Console.WriteLine("Maths Mark : "+MathsMarks);
            System.Console.WriteLine("Total mark is "+Total);
        }
    }
}