using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classCollegeAdmission
{
    //Enum Declaration
    public enum AdmissionStatus{Select,Admitted,Cancelled}
    public class AdmissionDetails
    {
        //field
        //static and private
        private int s_AdmissionID=1000;

        //autoproperty
        public string  AdmissionID{get;set;}
        public string StudentID{get;set;}
        public string DepartmentID{get;set;}
        public DateTime AdmissionDate{get;set;}
        public AdmissionStatus AdmissionStatus;

        //constructor
        public  AdmissionDetails(string studentID,string departmentID,DateTime  admissionDate,AdmissionStatus admissionStatus){
            //auto incremented value
            s_AdmissionID++;

            AdmissionID="AID"+s_AdmissionID;
            StudentID=studentID;
            DepartmentID=departmentID;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;

        }
    }
}