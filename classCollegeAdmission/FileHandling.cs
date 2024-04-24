using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace classCollegeAdmission
{
    public static  class FileHandling
    {
        public static  void Create(){

            //creating the directory
            if(!Directory.Exists("classCollegeAdmission")){
                System.Console.WriteLine("Creating file");
                Directory.CreateDirectory("classCollegeAdmission");
            }

            //department details info
            if(!File.Exists("classCollegeAdmission/DepartmentDetailsInfo.csv")){
                System.Console.WriteLine("Creating department file");
                File.Create("classCollegeAdmission/DepartmentDetailsInfo.csv");
            }

            //student details info
            if(!File.Exists("classCollegeAdmission/StudentDetailsInfo.csv")){
                System.Console.WriteLine("Creating  student file");
                File.Create("classCollegeAdmission/StudentDetailsInfo.csv");
            }

            //student Admission info
            if(!File.Exists("classCollegeAdmission/StudentAdmissionInfo.csv")){
                System.Console.WriteLine("Creating student admission info ");
              File.Create("classCollegeAdmission/StudentAdmissionInfo.csv");
            }
        }

        //writing  information to the csv files
        public static void WriteToCSV(){
            //student information  writing  the  csv file
            string [] contents=new string[Operation.studentList.Count];
            for(int i=0;i<Operation.studentList.Count;i++){
                                                                                              
                contents[i]=Operation.studentList[i].StudentID+"," +Operation.studentList[i].FatherName+","+Operation.studentList[i].StudentName+","+Operation.studentList[i].DOB+","+Operation.studentList[i].Gender+","+Operation.studentList[i].Physics+","+Operation.studentList[i].Chemistry+","+Operation.studentList[i].Maths;
            }
            File.WriteAllLines("classCollegeAdmission/StudentDetailsInfo.csv",contents);

             //department  information writing in the csv file
             string [] departments=new string[Operation.departmentList.Count];
             for(int i=0;i<Operation.departmentList.Count;i++){
                departments[i]=Operation.departmentList[i].DepartmentID+","+Operation.departmentList[i].DepartmentName+","+Operation.departmentList[i].NoOfSeats;
             }
             File.WriteAllLines("classCollegeAdmission/DepartmentDetailsInfo.csv",departments);

             //student addmission information in the csv file
             string [] admission=new string[Operation.admissionList.Count];
             for(int i=0;i<Operation.admissionList.Count;i++){
                
                admission[i]=Operation.admissionList[i].AdmissionID+","+Operation.admissionList[i].DepartmentID+","+","+Operation.admissionList[i].AdmissionDate.ToString("dd/MM/yyyy")+","+Operation.admissionList[i].AdmissionStatus;
             }
             File.WriteAllLines("classCollegeAdmission/StudentAdmissionInfo.csv",admission);
        }

       

        
    }
}