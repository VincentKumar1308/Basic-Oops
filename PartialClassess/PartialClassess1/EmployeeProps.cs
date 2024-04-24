using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess1
{
    public enum Gender {Male,Female,Others}
    public partial class EmployeeInfo
    {
        

        //properties
            private static int s_employeeID=1000;
            public string EmployeeID{get;}
            public  string Name{get;set;}
            Gender Gender;
            public DateTime DOB{get;set;}
            public long PhoneNo{get;set;}
           

            
    }
}