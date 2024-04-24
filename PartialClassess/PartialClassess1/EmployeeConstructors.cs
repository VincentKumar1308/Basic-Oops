using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess1
{
    public partial class EmployeeInfo
    {

        //constructors
        public EmployeeInfo(string name,Gender gender,DateTime dob,long mobile){
            EmployeeID="EID"+(++s_employeeID);
            Name=name;
            Gender=gender;
            DOB=dob;
            PhoneNo=mobile;
        }
    }
}