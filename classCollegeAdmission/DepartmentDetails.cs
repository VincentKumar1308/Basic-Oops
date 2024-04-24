using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classCollegeAdmission
{
    public class DepartmentDetails
    {
        /*
        a.	DepartmentID – (AutoIncrement - DID101)
        b.	DepartmentName
        c.	NumberOfSeats
        */
        //fields
        private static int  s_DepartmentID=100;

        //autoproperty
        public string DepartmentID{get;}
        public string DepartmentName{get;set;}
        public int NoOfSeats{get;set;}

        //constructors
        public DepartmentDetails(string departmentName,int noOfSeats){
            s_DepartmentID++;
            DepartmentID="DID"+s_DepartmentID;
            DepartmentName=departmentName;
            NoOfSeats=noOfSeats;
        }
    }
}