using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassess2
{
    public partial class StudentInfo
    {
        public StudentInfo(string name,Gender gender1,DateTime  dob,long mobileNo,int physics,int  chemistry,int maths){
            StudentID="SID"+(++s_studentID);
            StudentName=name;
            Gender gender=gender1;
            DOB=dob;
            MobileNo=mobileNo;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}