using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classCollegeAdmission
{
   
   
    public static class Operation
    {
        //Locals/Global Objects Creation
        public static StudentDetails CurrentLoggedInStudent;
        public static List<StudentDetails>studentList=new List<StudentDetails>();
        public static List<DepartmentDetails>departmentList=new List<DepartmentDetails>();
        public static List<AdmissionDetails>admissionList=new List<AdmissionDetails>();


        // main menu
        //Adding Default Data

        public static void MainMenu()
        {
            string mainChoice="yes";
            do
            {
                System.Console.WriteLine("******************Welcome To Syncfusion College*************");
                //Need to show the main menu option
                System.Console.WriteLine("MainMenu\n1. Registration\n2. Login\n3. Department wise seat availability\n4. Exit");
                //Need to get an input from user and validate
                System.Console.Write("Select an option : ");
                int mainOption = int.Parse(Console.ReadLine());
                 //Need to create mainmenu structure
                switch (mainOption)
                {
                    case 1:
                        {
                            System.Console.WriteLine("*********Student Registration**********");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("*********Login***************");
                            StudentLogin();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("*******Departmentwise Seat Availability*********");
                            DepartmentwiseSeatAvailabilty();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("******Application Exited Successfullly*********");
                            Exit();
                            mainChoice="no";
                            break;
                        }
                }
                //Need to iterate until the option  is exit.


            } while (mainChoice=="yes");
        }//Main menu ends

        //Student  Registration
        public static void  Registration(){
            //Need to get required details
            System.Console.Write("Enter Your Name: ");
            string name=Console.ReadLine();
            System.Console.Write("Enter Your father name : ");
            string fatherName=Console.ReadLine();
            System.Console.Write("Enter your DOB as specified DD/MM/YYYY: ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            System.Console.Write("Enter Your gender (Male/Female): ");
            Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
            System.Console.Write("Enter Your Physics Marks :");
            int physicsMarks=int.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Chemistry Marks :");
            int chemistryMarks=int.Parse(Console.ReadLine());
            System.Console.Write("Enter Your Maths Marks :");
            int mathsMarks=int.Parse(Console.ReadLine());
            //Need to create an object
            StudentDetails student=new StudentDetails(name,fatherName,dob,gender,physicsMarks,chemistryMarks,mathsMarks);
            //Need to add in the list
            studentList.Add(student);
            //Need to display confirmation Message and ID.
            System.Console.WriteLine($"Registration successful. Student ID: {student.StudentID}");
           
            
           

            

        }//Student Registration Ends

        //Student Login 
        public static void StudentLogin(){
            //Need to get ID input
            System.Console.Write("Enter Your Student ID: ");
            string loginID=Console.ReadLine().ToUpper();
            //validate by its presence in the list
            bool isPresent=false;
            foreach(StudentDetails student in studentList){
                if(loginID.Equals(student.StudentID)){
                    isPresent=true;
                    //Assigning current user to global variable
                    CurrentLoggedInStudent=student;
                    System.Console.WriteLine("Logged In successfully");
                    //Need to cal submenu
                    SubMenu();
                    break;
                }
            }
            if(!isPresent){
                System.Console.WriteLine("Invalid ID or ID is not present ");
            }
            //if not - invalid Ends

        }//Student Login ends

        //submenu
        public static void SubMenu(){
            bool isMainMenu=true;
            do{
                System.Console.WriteLine("************SubMenu*************");
                //need to show sub menu option
                System.Console.WriteLine("Select an Option\n1. Check Eligiblity\n2. Show  Details\n3. Take Admission\n4. Cancel Admission\n5. Admission Details\n6.Exit");
                //Getting user  option
                System.Console.Write("Enter Your Option : ");
                //Need to create the submenu structure
                int subOption=int.Parse(Console.ReadLine());
                switch(subOption){
                    case 1:
                    {
                        System.Console.WriteLine("*******Checking Eligibility*********");
                        CheckEligibility();
                        break;
                    }
                    case 2:
                    {
                        System.Console.WriteLine("*******Show Details************");
                        ShowDetails();
                        break;
                    }
                    case 3:
                    {
                        System.Console.WriteLine("*********Take Admission*********");
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        System.Console.WriteLine("********Cancel Admission*********");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        System.Console.WriteLine("*******Admission Details**********");
                        AdmissionDetails();
                        break;
                    }
                    case 6:
                    {
                        System.Console.WriteLine("*****Taking back to Main Menu******");
                        isMainMenu=false;
                        break;
                    }
                }
                //Iterate till exit
            }while(isMainMenu);
        }//submenu ends

        //check eligibility
        public  static void CheckEligibility(){
            //Get the cut off value as input :
            System.Console.Write("Enter the cut off value: ");
            double cutOff=double.Parse(Console.ReadLine());
            //check eligible or not
            if(CurrentLoggedInStudent.CheckEligibility(cutOff)){
                System.Console.WriteLine("Student is eligible");
            }
            else{
                System.Console.WriteLine("Student is not eligible");
            }

        }//CheckEligibility Ends

        //show details
        public static void ShowDetails(){
            //Need to show current student's details
            System.Console.WriteLine("|Student ID|Student Name| Father Name| DOB|Gender|Physics Marks|Chemistry Marks|Maths Marks|");
           Console.WriteLine($"|{CurrentLoggedInStudent.StudentID}|{CurrentLoggedInStudent.StudentName}|{CurrentLoggedInStudent.FatherName}|{CurrentLoggedInStudent.DOB}|{CurrentLoggedInStudent.Gender}|{CurrentLoggedInStudent.Physics}|{CurrentLoggedInStudent.Chemistry}|{CurrentLoggedInStudent.Maths}");
         
 
        }//show details ends

        //take admission
        public static void TakeAdmission(){
            //Need to show available department details
            DepartmentwiseSeatAvailabilty();
            //Ask department ID from User
            Console.Write("Select a department ID: ");
            string departmentID=Console.ReadLine().ToUpper();
            //check ID is present or not
            bool isValidDepartmentID=false;
            foreach(DepartmentDetails  department in departmentList){
                if(department.DepartmentID.Equals(departmentID)){
                    isValidDepartmentID=true;
                    //check the student is eligible or not
                    if(CurrentLoggedInStudent.CheckEligibility(75.0)){
                        //check the seat availability
                        if(department.NoOfSeats>0){
                            //check student already taken any admission
                            bool isAlreadyAdmissionTaken=false;
                            foreach(AdmissionDetails admission in  admissionList){
                                if(CurrentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted)){
                                    isAlreadyAdmissionTaken=true;

                                }
                            }
                            if(!isAlreadyAdmissionTaken){
                                //create admission objects
                                AdmissionDetails admission=new AdmissionDetails(CurrentLoggedInStudent.StudentID,department.DepartmentID,DateTime.Now,AdmissionStatus.Admitted);
                                //reduce seat count
                                department.NoOfSeats--;
                                //add in the admission list
                                admissionList.Add(admission);
                                //display admission successful message
                                System.Console.WriteLine($"You have taken admission successfully. Admission  ID: {admission.AdmissionID}");

                            }
                            else
                            {
                                System.Console.WriteLine("You have already taken an admission");
                            }

                        }
                        else
                        {
                            System.Console.WriteLine("Seats are not available");
                        }
                       
                    }
                    else
                    {
                        Console.WriteLine("You are not eligible dut to low cutoff");
                    }
                   

                    break;

                }
            }
            if(!isValidDepartmentID){
                System.Console.WriteLine("Invalid Department ID");
            }
            

        }//take admission ends

        //cancel admission
        public static void CancelAdmission(){
            //check the student is taken any admission and display it.
            bool isCancelled=false;
            foreach(AdmissionDetails admission in admissionList){
                if(CurrentLoggedInStudent.StudentID.Equals(admission.StudentID) && admission.AdmissionStatus.Equals(AdmissionStatus.Admitted)){
                    isCancelled=true;
                    //cancel the found admission
                    admission.AdmissionStatus=AdmissionStatus.Cancelled;
                    //return the seat to the  department.
                    foreach(DepartmentDetails department in departmentList){
                        if(department.DepartmentID==admission.DepartmentID){
                            department.NoOfSeats+=1;
                            break;
                        }
                    }
                    break;
                }
            }
            if(!isCancelled){
                System.Console.WriteLine("You have not admission to cancel ");
            }
           

        }//cancel admission ends

        //admission details
        public static  void AdmissionDetails(){
            //Need to show curent  addmission  details of the user
             foreach(AdmissionDetails admission  in admissionList){
                if(admission.StudentID.Equals(CurrentLoggedInStudent.StudentID)){
                   Console.WriteLine($"|{admission.AdmissionID}|{admission.StudentID}|{admission.DepartmentID}|{admission.AdmissionDate}|{admission.AdmissionStatus}");

                }
            }

        }

        //Departmentwise Seat availability
        public static void DepartmentwiseSeatAvailabilty(){
            //Need to show all department  details

            Console.WriteLine("DepartmentID | DepartmentName | NumberOfSeats|");
            foreach(DepartmentDetails department in departmentList){
                Console.WriteLine($"|{department.DepartmentID}|{department.DepartmentName}|{department.NoOfSeats}");
            }
            Console.WriteLine();

        }//departmentwise seat availability  ends

        //exit
        public  static  void Exit(){

        }//student exit ends

        public static void AddDefaultData()
        {
            //student registration default  data
            StudentDetails student1=new StudentDetails("Ravichandran E",	"Ettapparajan",	new DateTime(1999,11,11),Gender.Male,	95,	95,	95);
            studentList.Add(student1);
            StudentDetails student2=new StudentDetails("Baskaran S","	Sethurajan"	,new DateTime(1999,11,11)	,Gender.Male	,95	,95	,95);
            studentList.Add(student2);

            //department details default data
            DepartmentDetails department1=new DepartmentDetails("EEE",29);
            DepartmentDetails department2=new DepartmentDetails("CSE",29);
            DepartmentDetails department3=new DepartmentDetails("MECH",30);
            DepartmentDetails department4=new DepartmentDetails("ECE",30);
            departmentList.AddRange(new List<DepartmentDetails>{department1,department2,department3,department4});
            
            //admission details default data
            AdmissionDetails addmission1=new AdmissionDetails("SF3001","DID101",new DateTime(2022,05,11),AdmissionStatus.Admitted);
            AdmissionDetails addmission2=new AdmissionDetails("SF3002","DID102",new DateTime(2022,05,12),AdmissionStatus.Admitted);
            admissionList.AddRange(new List<AdmissionDetails>{addmission1,addmission2});

            //printing the data
            
           
           

    }
    }
}